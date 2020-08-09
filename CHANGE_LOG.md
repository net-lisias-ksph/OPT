# Orbit Portal Technology [OPT] Spaceplane Parts :: Change Log

* 2016-1117: 1.9.1 (K.Yeon) for KSP 1.2
	+ Added J Inline Boarding Ramp, J rear boarding ladder, both have a small IVA (in utility section)
	+ Added IVA to J-SL, J-HT, J-QS. I wasn't happy with the J crew tank, I will remake it and upload it next patch.
	+ ASET prop updated to a version updated by forum user veld (color tag fix)
	+ J Aerospike is now under "OPT Propulsion Science Division" manufacturer tab
	+ J science lab increased data storage from 500 to 1050
	+ Module Lifting Surface's drag values corrected
	+ K Spaceplane cockpit's bulkhead profile changed from 'K' to 'k'
	+ FSFuelSwitch Mass Discrepancy Error should be fixed
	+ In parts config file, part's name have been moved to the top.
	+ Updated firespitter to 7.4.2
	+ Updated module manager to 2.7.4
* 2016-1030: 1.9.0 (K.Yeon) for KSP 1.0.4
	+ OPT 1.9.0:
		- Increased all liquid fuel tank capacity by 25%
		- Increased J-HT cockpit's fuel capacity by 100%
		- Mass rounding to 2 decimals
		- Fixed new ILS cockpit's collider issue
		- Lot's of name changes for consistency
		- Changed k cockpit's max intake air amount to 5
		- Added "standalone = True" to J rcs, J nose
	+ Test release 4:
		- ILS crew reduced from 5 to 3
		- ISP crew reduced from 5 to 3
		- Added work in progress internals
		- Added ASET's prop for Mk2 cockpit for testing purpose
		- Added untextured IVA for all crewed parts
		- The newer mk2_cockpit, ils_cockpit, and j_cockpit has been renamed to: mk2_cockpitv2, ils_cockpitv2, and j_cockpitv2
		- Updated prebuilt crafts to 3: ATXJet, Kannam II SSTO and Balari V SSTO
		- Many parts price and tech rebalanced
		- Added lights to parts with window
		- Added emissive to J aerospike
		- Added and adjusted CLS, default fuel, MFT, RF, TACLS mm config
	+ Test release 3:
		- Added a version of J QS cockpit without intake
		- Added the Phoenix, ILS and ISP cockpit
		- Changed engine's mesh= to model {}
		- Taken out the unused cockpit IVAs
	+ Test release 2:
		- Added K Parts (10 in total)
		- Added 3 test crafts (1 jet, 2 ssto (I tested the ssto both go make into 80km orbit and back))
		- added indentation and some spacing to config files
		- added {node_attach = 2.3, 0.0, 0.0, 0.0, 0.0, 0.0, 2} to j fuel Tank 2m, 4m service bay and deployment bay
		- Added fuel switch to J deployment bay, service bay, inline docking port, inline large docking port.
		- part's with animation lift values adjusted. (recalculated from closed position instead of open)
		- J heat resistant nose moved to Fuel tank category, added kerbnet access
		- Moved J tail to fuel tank category
		- Added (stagingIcon = DECOUPLER_HOR; staged = False; stagingEnabled = False) to inline Docking ports, moved to coupling
		- J service bay, cargo bay moved to payload
		- Added kerbnet and experiment management to J lab
		- Added crew report to J crew, added useageReqMask to crew report
		- Changed J Large docking port disk to no attach
		- Fixed J Science node from 2.003 to 2
		- Added fuel switch to J engine mount, 2.5m tail and moved to fueltank category
		- Got the DroneCore with RCS to show up (don’t know how)
		- Fixed J aerodynamic tail's node
		- Changed ModuleRCS to ModuleRCSFX
	+ Test release 1: (from v1.8Test4)
		- Texture change for most fuselage parts
		- Some models are smoothened (at certain angles, some part no longer have different shines to another part)
		- New model for J space plane cockpit
		- Added JQS
		- Added J Deployment Bay
		- Added J Inline Docking port (small and large)
* 2015-0705: 1.7 (K.Yeon) for KSP 0.90
	+ V1.7
		- Firespitter not included anymore
		- 2 new cockpits
		- a new control surface (stabilizer type a)
		- A advanced turboramjet replaced original turboramjet
		- j and k adaptor plates are replaced by adaptors
		- Remodelled k fuselages and ARI engine
		- Rebalanced part's mass and lifting body values
		- Rebalanced Cost and techtrees
		- Wing's CoL is offsetted more towards the control surface
		- Various of minor bug fixes
		- FAR support
		- RealFuel Support
		- KM_gimbal Support
		- Added some basic IVA
		- note more detailed UpdateNode can be viewed on forum page72
* 2015-0517: 1.6.9 (K.Yeon) for KSP 0.7.3
	+ V1.6.9
		- Rebalance for v1.0.2
		- Added few WIP IVAs
		- Remodeled wing parts
		- turboramjet only have 1 mode
* 2015-0222: 1.6 (K.Yeon) for KSP 1.0.2
	+ V1.6
		- K Cockpit, FuelTank
		- Added 4 wing parts
		- Added Landing gear L
		- Rework on the old I cockpit
		- Rework on current ILS cockpit
		- Rebalanced engine heat production
		- Rebalanced Fueltank (lots of reduction)
		- Fixed Cockpit lights
		- Fixed Landing Gear Break and dampers
		- Part's strenth adjusted
		- 3 new aircraft added
		- Updated Module Manager (2.5.10)
		- Updated Firespitter.dll on 22/02/2015
* Previous Versions (M.I.A.)
	+ V1.4
		- FAR/NEAR/TACLS Mod Support
		- Add J Utility Bay
		- Add Mk2-J Adaptor
		- Add light options to windowed parts
		- Landing lights implemented on landing gears
		- Landing gear's property has been enhanced
		- KyEngine is Renamed to "ARIE" Engine
		- ARIE Engine's property has been enhanced
		- Multiple texture improvement
		- J Drop Bay now have separate door animations and removed ends
		- Improved IVA on Mk23 and JSL Cockpit
	+ V1.5
		- New Mk2 sized atmospheric engine
		- New J Linear Aerospike Engine
		- New Sci-fi Dark Drive Engine
		- New J and K adaptor Plate
		- New J drone core and Tail
		- Fixed FAR/NEAR support
		- Added DRE support
		- Able to filter by agency in 0.9
		- All parts updated to new Textures
		- Landing gear fixed, model changed
		- Rework on J docking port
		- ARIE mk1 engine is now air independent
		- Mk1 compressor no longer exists
		- J-f parts replaced by K parts
		- J-f Cargo Tail removed. (will be adding K version)
		- Removed IVA (still WIP)
	+ V1.4.9
		- Overhaul on most parts
		- new system for ARIEngine
		- J-freighter Parts replaced J 8m Cargo Bay
		- new ij adaptor
		- isp cockpit replaced mk23
		- ils's model replaced by mk23
		- RPM not included, i recommend download it when is updated!
	+ V1.3.1
		- Fixed KyEngine's Node
		- Added 8mCargoBay inside Nodes
		- Added 3 prebuild Crafts
	+ V1.3
		- Remodel, retexture on most parts.
		- All J parts now only have One note on each side
		- Reduced some texture size
		- Fixed JsAdaptorSeam
		- Fixed Parts falling through ground bug
		- Fixed EVA will throw you away bug on J, Mk23 cockpit
		- KyEngine's property is enhanced
		- More balanced Lifts on parts, J parts now have large drag at Max AOA,
		- aircrafts might lose controll more easily.
		- Remodel Mk23Cockpit
		- Added WIP Mk23 and J cockpit IVA (these IVAs will be improved)
		- Added 2 landing gears (Texture and shape will be improved)
		- Added Flag for OPT
		- Renamed Mod from IHYL Space Plane Parts to OPT Space Plane Parts
		- Included JSI RPM Add-on By Mihara,
			- [Forum](http://forum.kerbalspaceprogram.com/threads/57603)
		- Included SpitFire Plugin By Snjo,
			- [Forum](http://forum.kerbalspaceprogram.com/threads/24551-Firespitter-propeller-plane-and-helicopter-parts-v6-3-5-(Sep-1st)-for-KSP-0-24-2)
	+ V1.2.2
		- Added JSL cockpit
		- Added KyEngine
		- Added ILS Cockpit IVA (not yet finished)
	+ V1.2.1
		- Fixed DropBay Seam
	+ V1.2
		- Added Drop Bay
		- Added ILS Cockpit (will no longer throw kerbals out into space when EVA)
	+ V1.1
		- Fixed Node dissapere issue
		- Added js adaptor mono propellant tank
