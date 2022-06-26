﻿/* jhincapie/Util.KeyCodes.cs
 * https://gist.github.com/jhincapie/8a4c95d5cbe81d79b329ffc37e9f6c97
 */

using System.Collections.Generic;
using UnityEngine;

namespace Windows.Utils
{
    public enum VK
    {
        LeftButton = 0x01,
        RightButton = 0x02,
        Cancel = 0x03,
        MiddleButton = 0x04,
        ExtraButton1 = 0x05,
        ExtraButton2 = 0x06,
        Back = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Return = 0x0D,
        Shift = 0x10,
        Control = 0x11,
        Menu = 0x12,
        Pause = 0x13,
        CapsLock = 0x14,
        Kana = 0x15,
        Hangeul = 0x15,
        Hangul = 0x15,
        Junja = 0x17,
        Final = 0x18,
        Hanja = 0x19,
        Kanji = 0x19,
        Escape = 0x1B,
        Convert = 0x1C,
        NonConvert = 0x1D,
        Accept = 0x1E,
        ModeChange = 0x1F,
        Space = 0x20,
        Prior = 0x21,
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        N0 = 0x30,
        N1 = 0x31,
        N2 = 0x32,
        N3 = 0x33,
        N4 = 0x34,
        N5 = 0x35,
        N6 = 0x36,
        N7 = 0x37,
        N8 = 0x38,
        N9 = 0x39,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LeftWindows = 0x5B,
        RightWindows = 0x5C,
        Application = 0x5D,
        Sleep = 0x5F,
        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        NumLock = 0x90,
        ScrollLock = 0x91,
        NEC_Equal = 0x92,
        Fujitsu_Jisho = 0x92,
        Fujitsu_Masshou = 0x93,
        Fujitsu_Touroku = 0x94,
        Fujitsu_Loya = 0x95,
        Fujitsu_Roya = 0x96,
        LeftShift = 0xA0,
        RightShift = 0xA1,
        LeftControl = 0xA2,
        RightControl = 0xA3,
        LeftMenu = 0xA4,
        RightMenu = 0xA5,
        BrowserBack = 0xA6,
        BrowserForward = 0xA7,
        BrowserRefresh = 0xA8,
        BrowserStop = 0xA9,
        BrowserSearch = 0xAA,
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,
        VolumeMute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        MediaNextTrack = 0xB0,
        MediaPrevTrack = 0xB1,
        MediaStop = 0xB2,
        MediaPlayPause = 0xB3,
        LaunchMail = 0xB4,
        LaunchMediaSelect = 0xB5,
        LaunchApplication1 = 0xB6,
        LaunchApplication2 = 0xB7,
        OEM1 = 0xBA,
        OEMPlus = 0xBB,
        OEMComma = 0xBC,
        OEMMinus = 0xBD,
        OEMPeriod = 0xBE,
        OEM2 = 0xBF,
        OEM3 = 0xC0,
        OEM4 = 0xDB,
        OEM5 = 0xDC,
        OEM6 = 0xDD,
        OEM7 = 0xDE,
        OEM8 = 0xDF,
        OEMAX = 0xE1,
        OEM102 = 0xE2,
        ICOHelp = 0xE3,
        ICO00 = 0xE4,
        ProcessKey = 0xE5,
        ICOClear = 0xE6,
        Packet = 0xE7,
        OEMReset = 0xE9,
        OEMJump = 0xEA,
        OEMPA1 = 0xEB,
        OEMPA2 = 0xEC,
        OEMPA3 = 0xED,
        OEMWSCtrl = 0xEE,
        OEMCUSel = 0xEF,
        OEMATTN = 0xF0,
        OEMFinish = 0xF1,
        OEMCopy = 0xF2,
        OEMAuto = 0xF3,
        OEMENLW = 0xF4,
        OEMBackTab = 0xF5,
        ATTN = 0xF6,
        CRSel = 0xF7,
        EXSel = 0xF8,
        EREOF = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        Noname = 0xFC,
        PA1 = 0xFD,
        OEMClear = 0xFE
    }
    
    public static class VirtualKeyMapping
    {
        
        public const int VK_ABNT_C1 = 0xC1; //	Abnt C1
        public const int VK_ABNT_C2 = 0xC2; //	Abnt C2
        public const int VK_ADD = 0x6B; //	Numpad +
        public const int VK_ATTN = 0xF6; //	Attn
        public const int VK_BACK = 0x08; //	Backspace
        public const int VK_CANCEL = 0x03; //	Break
        public const int VK_CLEAR = 0x0C; //	Clear
        public const int VK_CRSEL = 0xF7; //	Cr Sel
        public const int VK_DECIMAL = 0x6E; //	Numpad.
        public const int VK_DIVIDE = 0x6F; //	Numpad /
        public const int VK_EREOF = 0xF9; //	Er Eof
        public const int VK_ESCAPE = 0x1B; //	Esc
        public const int VK_EXECUTE = 0x2B; //	Execute
        public const int VK_EXSEL = 0xF8; //	Ex Sel
        public const int VK_ICO_CLEAR = 0xE6; //	IcoClr
        public const int VK_ICO_HELP = 0xE3; //	IcoHlp

        public const int VK_KEY_0 = 0x30; // ('0')	0
        public const int VK_KEY_1 = 0x31; // ('1')	1
        public const int VK_KEY_2 = 0x32; // ('2')	2
        public const int VK_KEY_3 = 0x33; // ('3')	3
        public const int VK_KEY_4 = 0x34; // ('4')	4
        public const int VK_KEY_5 = 0x35; // ('5')	5
        public const int VK_KEY_6 = 0x36; // ('6')	6
        public const int VK_KEY_7 = 0x37; // ('7')	7
        public const int VK_KEY_8 = 0x38; // ('8')	8
        public const int VK_KEY_9 = 0x39; // ('9')	9
        public const int VK_KEY_A = 0x41; // ('A')	A
        public const int VK_KEY_B = 0x42; // ('B')	B
        public const int VK_KEY_C = 0x43; // ('C')	C
        public const int VK_KEY_D = 0x44; // ('D')	D
        public const int VK_KEY_E = 0x45; // ('E')	E
        public const int VK_KEY_F = 0x46; // ('F')	F
        public const int VK_KEY_G = 0x47; // ('G')	G
        public const int VK_KEY_H = 0x48; // ('H')	H
        public const int VK_KEY_I = 0x49; // ('I')	I
        public const int VK_KEY_J = 0x4A; // ('J')	J
        public const int VK_KEY_K = 0x4B; // ('K')	K
        public const int VK_KEY_L = 0x4C; // ('L')	L
        public const int VK_KEY_M = 0x4D; // ('M')	M
        public const int VK_KEY_N = 0x4E; // ('N')	N
        public const int VK_KEY_O = 0x4F; // ('O')	O
        public const int VK_KEY_P = 0x50; // ('P')	P
        public const int VK_KEY_Q = 0x51; // ('Q')	Q
        public const int VK_KEY_R = 0x52; // ('R')	R
        public const int VK_KEY_S = 0x53; // ('S')	S
        public const int VK_KEY_T = 0x54; // ('T')	T
        public const int VK_KEY_U = 0x55; // ('U')	U
        public const int VK_KEY_V = 0x56; // ('V')	V
        public const int VK_KEY_W = 0x57; // ('W')	W
        public const int VK_KEY_X = 0x58; // ('X')	X
        public const int VK_KEY_Y = 0x59; // ('Y')	Y
        public const int VK_KEY_Z = 0x5A; // ('Z')	Z

        public const int VK_MULTIPLY = 0x6A; //	Numpad X
        public const int VK_NONAME = 0xFC; //	NoName

        public const int VK_NUMPAD0 = 0x60; //	Numpad 0
        public const int VK_NUMPAD1 = 0x61; //	Numpad 1
        public const int VK_NUMPAD2 = 0x62; //	Numpad 2
        public const int VK_NUMPAD3 = 0x63; //	Numpad 3
        public const int VK_NUMPAD4 = 0x64; //	Numpad 4
        public const int VK_NUMPAD5 = 0x65; //	Numpad 5
        public const int VK_NUMPAD6 = 0x66; //	Numpad 6
        public const int VK_NUMPAD7 = 0x67; //	Numpad 7
        public const int VK_NUMPAD8 = 0x68; //	Numpad 8
        public const int VK_NUMPAD9 = 0x69; //	Numpad 9

        public const int VK_OEM_1 = 0xBA; //	OEM_1(: ;)
        public const int VK_OEM_102 = 0xE2; //	OEM_102(> <)
        public const int VK_OEM_2 = 0xBF; //	OEM_2(? /)
        public const int VK_OEM_3 = 0xC0; //	OEM_3(~ `)
        public const int VK_OEM_4 = 0xDB; //	OEM_4({ [)
        public const int VK_OEM_5 = 0xDC; //	OEM_5(\| \)
        public const int VK_OEM_6 = 0xDD; //	OEM_6(} ])
        public const int VK_OEM_7 = 0xDE; //	OEM_7(" ')
        public const int VK_OEM_8 = 0xDF; //	OEM_8 (§ !)
        public const int VK_OEM_ATTN = 0xF0; //	Oem Attn
        public const int VK_OEM_AUTO = 0xF3; //	Auto
        public const int VK_OEM_AX = 0xE1; //	Ax
        public const int VK_OEM_BACKTAB = 0xF5; //	Back Tab
        public const int VK_OEM_CLEAR = 0xFE; //	OemClr
        public const int VK_OEM_COMMA = 0xBC; //	OEM_COMMA(< ,)
        public const int VK_OEM_COPY = 0xF2; //	Copy
        public const int VK_OEM_CUSEL = 0xEF; //	Cu Sel
        public const int VK_OEM_ENLW = 0xF4; //	Enlw
        public const int VK_OEM_FINISH = 0xF1; //	Finish
        public const int VK_OEM_FJ_LOYA = 0x95; //	Loya
        public const int VK_OEM_FJ_MASSHOU = 0x93; //	Mashu
        public const int VK_OEM_FJ_ROYA = 0x96; //	Roya
        public const int VK_OEM_FJ_TOUROKU = 0x94; //	Touroku
        public const int VK_OEM_JUMP = 0xEA; //	Jump
        public const int VK_OEM_MINUS = 0xBD; //	OEM_MINUS(_ -)
        public const int VK_OEM_PA1 = 0xEB; //	OemPa1
        public const int VK_OEM_PA2 = 0xEC; //	OemPa2
        public const int VK_OEM_PA3 = 0xED; //	OemPa3
        public const int VK_OEM_PERIOD = 0xBE; //	OEM_PERIOD(> .)
        public const int VK_OEM_PLUS = 0xBB; //	OEM_PLUS(+ =)
        public const int VK_OEM_RESET = 0xE9; //	Reset
        public const int VK_OEM_WSCTRL = 0xEE; //	WsCtrl
        public const int VK_PA1 = 0xFD; //	Pa1
        public const int VK_PACKET = 0xE7; //	Packet
        public const int VK_PLAY = 0xFA; //	Play
        public const int VK_PROCESSKEY = 0xE5; //	Process
        public const int VK_RETURN = 0x0D; //	Enter
        public const int VK_SELECT = 0x29; //	Select
        public const int VK_SEPARATOR = 0x6C; //	Separator
        public const int VK_SPACE = 0x20; //	Space
        public const int VK_SUBTRACT = 0x6D; //	Num -
        public const int VK_TAB = 0x09; //	Tab
        public const int VK_ZOOM = 0xFB; //	Zoom

        public const int VK__none_ = 0xFF; //	no VK mapping
        public const int VK_ACCEPT = 0x1E; //	Accept
        public const int VK_APPS = 0x5D; //	Context Menu
        public const int VK_BROWSER_BACK = 0xA6; //	Browser Back
        public const int VK_BROWSER_FAVORITES = 0xAB; //	Browser Favorites
        public const int VK_BROWSER_FORWARD = 0xA7; //	Browser Forward
        public const int VK_BROWSER_HOME = 0xAC; //	Browser Home
        public const int VK_BROWSER_REFRESH = 0xA8; //	Browser Refresh
        public const int VK_BROWSER_SEARCH = 0xAA; //	Browser Search
        public const int VK_BROWSER_STOP = 0xA9; //	Browser Stop
        public const int VK_CAPITAL = 0x14; //	Caps Lock
        public const int VK_CONVERT = 0x1C; //	Convert
        public const int VK_DELETE = 0x2E; //	Delete
        public const int VK_DOWN = 0x28; //	Arrow Down
        public const int VK_END = 0x23; //	End

        public const int VK_F1 = 0x70; //	F1
        public const int VK_F10 = 0x79; //	F10
        public const int VK_F11 = 0x7A; //	F11
        public const int VK_F12 = 0x7B; //	F12
        public const int VK_F13 = 0x7C; //	F13
        public const int VK_F14 = 0x7D; //	F14
        public const int VK_F15 = 0x7E; //	F15
        public const int VK_F16 = 0x7F; //	F16
        public const int VK_F17 = 0x80; //	F17
        public const int VK_F18 = 0x81; //	F18
        public const int VK_F19 = 0x82; //	F19
        public const int VK_F2 = 0x71; //	F2
        public const int VK_F20 = 0x83; //	F20
        public const int VK_F21 = 0x84; //	F21
        public const int VK_F22 = 0x85; //	F22
        public const int VK_F23 = 0x86; //	F23
        public const int VK_F24 = 0x87; //	F24
        public const int VK_F3 = 0x72; //	F3
        public const int VK_F4 = 0x73; //	F4
        public const int VK_F5 = 0x74; //	F5
        public const int VK_F6 = 0x75; //	F6
        public const int VK_F7 = 0x76; //	F7
        public const int VK_F8 = 0x77; //	F8
        public const int VK_F9 = 0x78; //	F9

        public const int VK_FINAL = 0x18; //	Final
        public const int VK_HELP = 0x2F; //	Help
        public const int VK_HOME = 0x24; //	Home
        public const int VK_ICO_00 = 0xE4; //	Ico00*
        public const int VK_INSERT = 0x2D; //	Insert
        public const int VK_JUNJA = 0x17; //	Junja
        public const int VK_KANA = 0x15; //	Kana
        public const int VK_KANJI = 0x19; //	Kanji
        public const int VK_LAUNCH_APP1 = 0xB6; //	App1
        public const int VK_LAUNCH_APP2 = 0xB7; //	App2
        public const int VK_LAUNCH_MAIL = 0xB4; //	Mail
        public const int VK_LAUNCH_MEDIA_SELECT = 0xB5; //	Media
        public const int VK_LBUTTON = 0x01; //	Left Button **
        public const int VK_LCONTROL = 0xA2; //	Left Ctrl
        public const int VK_LEFT = 0x25; //	Arrow Left
        public const int VK_LMENU = 0xA4; //	Left Alt
        public const int VK_LSHIFT = 0xA0; //	Left Shift
        public const int VK_LWIN = 0x5B; //	Left Win
        public const int VK_MBUTTON = 0x04; //	Middle Button **
        public const int VK_MEDIA_NEXT_TRACK = 0xB0; //	Next Track
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3; //	Play / Pause
        public const int VK_MEDIA_PREV_TRACK = 0xB1; //	Previous Track
        public const int VK_MEDIA_STOP = 0xB2; //	Stop
        public const int VK_MODECHANGE = 0x1F; //	Mode Change
        public const int VK_NEXT = 0x22; //	Page Down
        public const int VK_NONCONVERT = 0x1D; //	Non Convert
        public const int VK_NUMLOCK = 0x90; //	Num Lock
        public const int VK_OEM_FJ_JISHO = 0x92; //	Jisho
        public const int VK_PAUSE = 0x13; //	Pause
        public const int VK_PRINT = 0x2A; //	Print
        public const int VK_PRIOR = 0x21; //	Page Up
        public const int VK_RBUTTON = 0x02; //	Right Button **
        public const int VK_RCONTROL = 0xA3; //	Right Ctrl
        public const int VK_RIGHT = 0x27; //	Arrow Right
        public const int VK_RMENU = 0xA5; //	Right Alt
        public const int VK_RSHIFT = 0xA1; //	Right Shift
        public const int VK_RWIN = 0x5C; //	Right Win
        public const int VK_SCROLL = 0x91; //	Scrol Lock
        public const int VK_SLEEP = 0x5F; //	Sleep
        public const int VK_SNAPSHOT = 0x2C; //	Print Screen
        public const int VK_UP = 0x26; //	Arrow Up
        public const int VK_VOLUME_DOWN = 0xAE; //	Volume Down
        public const int VK_VOLUME_MUTE = 0xAD; //	Volume Mute
        public const int VK_VOLUME_UP = 0xAF; //	Volume Up
        public const int VK_XBUTTON1 = 0x05; //	X Button 1 **
        public const int VK_XBUTTON2 = 0x06; //	X Button 2 **

        public static void SetMappings(Dictionary<ushort, KeyCode> map)
        {
            map[VK_ADD] = KeyCode.Plus; // 0x6B;//	Numpad +
            map[VK_BACK] = KeyCode.Backspace; // 0x08;//	Backspace
            map[VK_CANCEL] = KeyCode.Break; // 0x03;//	Break
            map[VK_CLEAR] = KeyCode.Clear; //0x0C;//	Clear
            map[VK_DECIMAL] = KeyCode.Numlock; //0x6E;//	Numpad.
            map[VK_DIVIDE] = KeyCode.KeypadDivide; //0x6F;//	Numpad /
            map[VK_ESCAPE] = KeyCode.Escape; //0x1B;//	Esc
            map[VK_ICO_HELP] = KeyCode.Help; //0xE3;//	IcoHlp

            map[VK_KEY_0] = KeyCode.Alpha0; //0x30;// ('0')	0
            map[VK_KEY_1] = KeyCode.Alpha1; //0x31;// ('1')	1
            map[VK_KEY_2] = KeyCode.Alpha2; //0x32;// ('2')	2
            map[VK_KEY_3] = KeyCode.Alpha3; //0x33;// ('3')	3
            map[VK_KEY_4] = KeyCode.Alpha4; //0x34;// ('4')	4
            map[VK_KEY_5] = KeyCode.Alpha5; //0x35;// ('5')	5
            map[VK_KEY_6] = KeyCode.Alpha6; //0x36;// ('6')	6
            map[VK_KEY_7] = KeyCode.Alpha7; //0x37;// ('7')	7
            map[VK_KEY_8] = KeyCode.Alpha8; //0x38;// ('8')	8
            map[VK_KEY_9] = KeyCode.Alpha9; //0x39;// ('9')	9
            map[VK_KEY_A] = KeyCode.A; //0x41;// ('A')	A
            map[VK_KEY_B] = KeyCode.B; //0x42;// ('B')	B
            map[VK_KEY_C] = KeyCode.C; //0x43;// ('C')	C
            map[VK_KEY_D] = KeyCode.D; //0x44;// ('D')	D
            map[VK_KEY_E] = KeyCode.E; //0x45;// ('E')	E
            map[VK_KEY_F] = KeyCode.F; //0x46;// ('F')	F
            map[VK_KEY_G] = KeyCode.G; //0x47;// ('G')	G
            map[VK_KEY_H] = KeyCode.H; //0x48;// ('H')	H
            map[VK_KEY_I] = KeyCode.I; //0x49;// ('I')	I
            map[VK_KEY_J] = KeyCode.J; //0x4A;// ('J')	J
            map[VK_KEY_K] = KeyCode.K; //0x4B;// ('K')	K
            map[VK_KEY_L] = KeyCode.L; //0x4C;// ('L')	L
            map[VK_KEY_M] = KeyCode.M; //0x4D;// ('M')	M
            map[VK_KEY_N] = KeyCode.N; //0x4E;// ('N')	N
            map[VK_KEY_O] = KeyCode.O; //0x4F;// ('O')	O
            map[VK_KEY_P] = KeyCode.P; //0x50;// ('P')	P
            map[VK_KEY_Q] = KeyCode.Q; //0x51;// ('Q')	Q
            map[VK_KEY_R] = KeyCode.R; //0x52;// ('R')	R
            map[VK_KEY_S] = KeyCode.S; //0x53;// ('S')	S
            map[VK_KEY_T] = KeyCode.T; //0x54;// ('T')	T
            map[VK_KEY_U] = KeyCode.U; //0x55;// ('U')	U
            map[VK_KEY_V] = KeyCode.V; //0x56;// ('V')	V
            map[VK_KEY_W] = KeyCode.W; //0x57;// ('W')	W
            map[VK_KEY_X] = KeyCode.X; //0x58;// ('X')	X
            map[VK_KEY_Y] = KeyCode.Y; //0x59;// ('Y')	Y
            map[VK_KEY_Z] = KeyCode.Z; // 0x5A;// ('Z')	Z

            map[VK_MULTIPLY] = KeyCode.KeypadMultiply; // 0x6A;//	Numpad*
            map[VK_NONAME] = KeyCode.None; // 0xFC;//	NoName

            map[VK_NUMPAD0] = KeyCode.Keypad0; //0x60;//	Numpad 0
            map[VK_NUMPAD1] = KeyCode.Keypad1; //0x61;//	Numpad 1
            map[VK_NUMPAD2] = KeyCode.Keypad2; //0x62;//	Numpad 2
            map[VK_NUMPAD3] = KeyCode.Keypad3; //0x63;//	Numpad 3
            map[VK_NUMPAD4] = KeyCode.Keypad4; //0x64;//	Numpad 4
            map[VK_NUMPAD5] = KeyCode.Keypad5; //0x65;//	Numpad 5
            map[VK_NUMPAD6] = KeyCode.Keypad6; //0x66;//	Numpad 6
            map[VK_NUMPAD7] = KeyCode.Keypad7; //0x67;//	Numpad 7
            map[VK_NUMPAD8] = KeyCode.Keypad8; //0x68;//	Numpad 8
            map[VK_NUMPAD9] = KeyCode.Keypad9; //0x69;//	Numpad 9

            map[VK_OEM_1] = KeyCode.Colon; // 0xBA;//	OEM_1(: ;)
            map[VK_OEM_102] = KeyCode.Greater; //0xE2;//	OEM_102(> <)
            map[VK_OEM_2] = KeyCode.Question; //0xBF;//	OEM_2(? /)
            map[VK_OEM_3] = KeyCode.BackQuote; //0xC0;//	OEM_3(~ `)
            map[VK_OEM_4] = KeyCode.LeftBracket; //0xDB;//	OEM_4({ [)
            map[VK_OEM_5] = KeyCode.Backslash; //0xDC;//	OEM_5(| \)
            map[VK_OEM_6] = KeyCode.RightBracket; //0xDD;//	OEM_6(} ])
            map[VK_OEM_7] = KeyCode.DoubleQuote; //0xDE;//	OEM_7(" ')
            map[VK_OEM_8] = KeyCode.Exclaim; //0xDF;//	OEM_8 (§ !)
            map[VK_OEM_ATTN] = KeyCode.At; //0xF0;//	Oem Attn
            map[VK_OEM_CLEAR] = KeyCode.Clear; //0xFE;//	OemClr
            map[VK_OEM_COMMA] = KeyCode.Comma; //0xBC;//	OEM_COMMA(< ,)
            map[VK_OEM_MINUS] = KeyCode.Minus; //0xBD;//	OEM_MINUS(_ -)
            map[VK_OEM_PERIOD] = KeyCode.Period; //0xBE;//	OEM_PERIOD(> .)
            map[VK_OEM_PLUS] = KeyCode.Plus; //0xBB;//	OEM_PLUS(+ =)
            map[VK_RETURN] = KeyCode.Return; //0x0D;//	Enter
            map[VK_SPACE] = KeyCode.Space; //0x20;//	Space
            map[VK_SUBTRACT] = KeyCode.KeypadMinus; //0x6D;//	Num -
            map[VK_TAB] = KeyCode.Tab; //0x09;//	Tab

            map[VK__none_] = KeyCode.None; //0xFF;//	no VK mapping
            map[VK_CAPITAL] = KeyCode.CapsLock; //0x14;//	Caps Lock
            map[VK_DELETE] = KeyCode.Delete; //0x2E;//	Delete
            map[VK_DOWN] = KeyCode.DownArrow; //0x28;//	Arrow Down
            map[VK_END] = KeyCode.End; //0x23;//	End

            map[VK_F1] = KeyCode.F1; //0x70;//	F1
            map[VK_F2] = KeyCode.F2; //0x71;//	F2
            map[VK_F3] = KeyCode.F3; //0x72;//	F3
            map[VK_F4] = KeyCode.F4; //0x73;//	F4
            map[VK_F5] = KeyCode.F5; //0x74;//	F5
            map[VK_F6] = KeyCode.F6; //0x75;//	F6
            map[VK_F7] = KeyCode.F7; //0x76;//	F7
            map[VK_F8] = KeyCode.F8; //0x77;//	F8
            map[VK_F9] = KeyCode.F9; //0x78;//	F9
            map[VK_F10] = KeyCode.F10; //0x79;//	F10
            map[VK_F11] = KeyCode.F11; //0x7A;//	F11
            map[VK_F12] = KeyCode.F12; //0x7B;//	F12
            map[VK_F13] = KeyCode.F13; //0x7C;//	F13
            map[VK_F14] = KeyCode.F14; //0x7D;//	F14
            map[VK_F15] = KeyCode.F15; //0x7E;//	F15

            map[VK_HELP] = KeyCode.Help; //0x2F;//	Help
            map[VK_HOME] = KeyCode.Home; //0x24;//	Home
            map[VK_INSERT] = KeyCode.Insert; //0x2D;//	Insert
            map[VK_LCONTROL] = KeyCode.LeftControl; //0xA2;//	Left Ctrl
            map[VK_LEFT] = KeyCode.LeftArrow; //0x25;//	Arrow Left
            map[VK_LMENU] = KeyCode.LeftAlt; //0xA4;//	Left Alt
            map[VK_LSHIFT] = KeyCode.LeftShift; //0xA0;//	Left Shift
            map[VK_LWIN] = KeyCode.LeftWindows; //0x5B;//	Left Win
            map[VK_NEXT] = KeyCode.PageDown; //0x22;//	Page Down
            map[VK_NUMLOCK] = KeyCode.Numlock; //0x90;//	Num Lock
            map[VK_PAUSE] = KeyCode.Pause; //0x13;//	Pause
            map[VK_PRINT] = KeyCode.Print; //0x2A;//	Print
            map[VK_PRIOR] = KeyCode.PageUp; //0x21;//	Page Up
            map[VK_RCONTROL] = KeyCode.RightControl; //0xA3;//	Right Ctrl
            map[VK_RIGHT] = KeyCode.RightArrow; //0x27;//	Arrow Right
            map[VK_RMENU] = KeyCode.RightAlt; //0xA5;//	Right Alt
            map[VK_RSHIFT] = KeyCode.RightShift; //0xA1;//	Right Shift
            map[VK_RWIN] = KeyCode.RightWindows; //0x5C;//	Right Win
            map[VK_SCROLL] = KeyCode.ScrollLock; //0x91;//	Scrol Lock
            map[VK_SNAPSHOT] = KeyCode.SysReq; //0x2C;//	Print Screen
            map[VK_UP] = KeyCode.UpArrow; //0x26;//	Arrow Up
        }
    }
}