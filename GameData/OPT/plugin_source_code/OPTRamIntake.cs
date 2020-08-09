using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OPT
///Many Codes are based on Snjo's Firespitter Moduleengines and code from
{
    public class OPTRamIntake : PartModule
    {
        [KSPField]
        public string intakeMeshName = "intake_transform";
        [KSPField(guiName = "Intake Efficiency", guiActive = true)]
        public double ramIntakeEfficiency = 0f;

       // [KSPField(guiName = "Mach Number", guiActive = true)]
        public double machNumber = 0f;

       // [KSPField(guiName = "Current Velocity", guiActive = true)]
        public double curVel = 0f;

        [KSPField(guiName = "Intake Size", guiActiveEditor = true)]
        public float intakeSize = 1f;

        [KSPField]
        public string SuperCompressedAir = "SuperCompressedAir";

        [KSPField(guiName = "Status", guiActive = true)]
        public string status = "Inactive";

        [KSPField(guiName = "Cause", guiActive = false)]
        public string cause = "";

        [KSPField(isPersistant = true)]
        public bool flameout = false;
        public bool overload = false;

        private Transform intakeMeshTransform;
        private ModuleResourceIntake intakeModule;
        /////////////////////////////////////////////////////////////////////////
        protected void updateStatus()
        {
            if (overload)
            {
                status = "Above Speed Limit!";
            }
            if (flameout)
            {
                status = "Not Enough Pressure!";
                Fields["cause"].guiActive = false;
            }
            else
            {
                status = "Active";
                Fields["cause"].guiActive = false;
            }
        }
        public override void OnStart(PartModule.StartState state)
        {
            base.OnStart(state);
            intakeMeshTransform = part.FindModelTransform(intakeMeshName);
            intakeModule = part.Modules.OfType<ModuleResourceIntake>().FirstOrDefault();
        }
        /////////////////////////////////////////////////////////////////////////Generate
        public virtual void FixedUpdate()
        {
           // Vector3 velocity = part.gameObject.rigidbody.velocity;
            machNumber = intakeModule.airSpeedGui/ 310;
            curVel = intakeModule.airSpeedGui;
                if ( part.staticPressureAtm > 0.0001 )
                {
                    if (machNumber > 2)
                    {
                        if (machNumber <= 3.2)
                        {
                            part.RequestResource(SuperCompressedAir, -1 * TimeWarp.deltaTime * intakeSize * (2 - (3.2 / machNumber)));
                            ramIntakeEfficiency = (2 - (3.2 / machNumber));
                            flameout = false;
                            overload = false;
                        }
                        if (machNumber > 3.2)
                        {
                            part.RequestResource(SuperCompressedAir, -1 * TimeWarp.deltaTime * intakeSize * 3.2 / machNumber);
                            ramIntakeEfficiency = 3.2 / machNumber;
                            flameout = false;
                            overload = false;
                        }
                        if (machNumber > 7)
                        {
                            part.RequestResource(SuperCompressedAir, -1 * TimeWarp.deltaTime * intakeSize * 0);
                            ramIntakeEfficiency =0;
                            flameout = false;
                            overload = true;
                        }
                    }
                    else
                    {
                        flameout = true;
                    }
                }
                else
                {
                    flameout = true;
                }
            updateStatus();
        }
    }
}
