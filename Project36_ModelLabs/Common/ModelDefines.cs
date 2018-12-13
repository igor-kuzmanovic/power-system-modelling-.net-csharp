using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

        REACTIVECAPABILITYCURVE             = 0x0001,
        CURVEDATA                           = 0x0002,
        SYNCHRONOUSMACHINE                  = 0x0003,
        FREQUENCYCONVERTER                  = 0x0004,
        SHUNTCOMPENSATOR                    = 0x0005,
        STATICVARCOMPENSATOR                = 0x0006,
        TERMINAL                            = 0x0007,
        REGULATINGCONTROL                   = 0x0008,
        CONTROL                             = 0x0009,
    }

    [Flags]
	public enum ModelCode : long
	{
        IDOBJ                                       = 0x1000000000000000,
        IDOBJ_GID                                   = 0x1000000000000104,
        IDOBJ_ALIASNAME                             = 0x1000000000000207,
        IDOBJ_MRID                                  = 0x1000000000000307,
        IDOBJ_NAME                                  = 0x1000000000000407,

        CURVE                                       = 0x1100000000000000,
        CURVE_CURVESTLYE                            = 0x110000000000010A,
        CURVE_XMULTIPLIER                           = 0x110000000000020A,
        CURVE_XUNIT                                 = 0x110000000000030A,
        CURVE_Y1MULTIPLIER                          = 0x110000000000040A,
        CURVE_Y1UNIT                                = 0x110000000000050A,
        CURVE_Y2MULTIPLIER                          = 0x110000000000060A,
        CURVE_Y2UNIT                                = 0x110000000000070A,
        CURVE_Y3MULTIPLIER                          = 0x110000000000080A,
        CURVE_Y3UNIT                                = 0x110000000000090A,
        CURVE_CURVEDATAS                            = 0x1100000000000A19,

        REACTIVECAPABILITYCURVE                     = 0x1110000000010000,
        REACTIVECAPABILITYCURVE_SYNCHRONOUSMACHINES = 0x1110000000010119,

        CURVEDATA                                   = 0x1200000000020000,
        CURVEDATA_XVALUE                            = 0x1200000000020105,
        CURVEDATA_Y1VALUE                           = 0x1200000000020205,
        CURVEDATA_Y2VALUE                           = 0x1200000000020305,
        CURVEDATA_Y3VALUE                           = 0x1200000000020405,
        CURVEDATA_CURVE                             = 0x1200000000020509,

        POWERSYSTEMRESOURCE                         = 0x1300000000000000,

        EQUIPMENT                                   = 0x1320000000000000,
        EQUIPMENT_AGGREGATE                         = 0x1320000000000101,
        EQUIPMENT_NORMALLYINSERVICE                 = 0x1320000000000201,

        CONDUCTINGEQUIPMENT                         = 0x1321000000000000,
        CONDUCTINGEQUIPMENT_TERMINALS               = 0x1321000000000119,

        REGULATINGCONDEQ                            = 0x1321100000000000,
        REGULATINGCONDEQ_CONTROLS                   = 0x1321100000000119,

        ROTATINGMACHINE                             = 0x1321110000000000,

        SYNCHRONOUSMACHINE                          = 0x1321111000030000,
        SYNCHRONOUSMACHINE_REACTIVECAPABILITYCURVES = 0x1321111000030109,

        FREQUENCYCONVERTER                          = 0x1321120000040000,

        SHUNTCOMPENSATOR                            = 0x1321130000050000,

        STATICVARCOMPENSATOR                        = 0x1321140000060000,

        TERMINAL                                    = 0x1400000000070000,
        TERMINAL_CONDUCTINGEQUIPMENT                = 0x1400000000070109,
        TERMINAL_REGULATINGCONTROL                  = 0x1400000000070219,

        REGULATINGCONTROL                           = 0x1310000000080000,
        REGULATINGCONTROL_DISCRETE                  = 0x1310000000080101,
        REGULATINGCONTROL_MODE                      = 0x131000000008020A,
        REGULATINGCONTROL_MONITOREDPHASE            = 0x131000000008030A,
        REGULATINGCONTROL_TARGETRANGE               = 0x1310000000080405,
        REGULATINGCONTROL_TARGETVALUE               = 0x1310000000080505,
        REGULATINGCONTROL_TERMINAL                  = 0x1310000000080609,

        CONTROL                                     = 0x1500000000090000,
        CONTROL_REGULATINGCONDEQ                    = 0x1500000000090109,
    }

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


