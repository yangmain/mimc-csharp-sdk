﻿using System;
namespace com.xiaomi.mimc.common
/*

* ==============================================================================
*
* Filename: $safeitemname$
* Description: 
*
* Created: $time$
* Compiler: Visual Studio 2017
*
* Author: zhangming8
* Company: Xiaomi.com
*
* ==============================================================================
*/
{
    public class Constant
    {
        public Constant()
        {
        }
        public enum OnlineStatus
        {
            Online,
            Offline
        }

        public const int MIMC_CHID = 9;

        public const uint CONN_BIN_PROTO_VERSION = 106;
        public const int CONN_BIN_PROTO_SDK = 33;

        // 关于各成员的偏移量
        public const byte V6_HEAD_LENGTH = 8;
        public const byte V6_BODY_HEADER_LENGTH = 8;
        public const byte V6_MAGIC_OFFSET = 0;
        public const byte V6_VERSION_OFFSET = 2;
        public const byte V6_BODYLEN_OFFSET = 4;
        public const byte V6_PAYLOADTYPE_OFFSET = 0;
        public const byte V6_HEADERLEN_OFFSET = 2;
        public const byte V6_PAYLOADLEN_OFFSET = 4;
        public const byte V6_CRC_LENGTH = 4;

        // 关于发送数据包的命令cmd
        public const String CMD_CONN = "CONN";
        public const String CMD_BIND = "BIND";
        public const String CMD_PING = "PING";
        public const String CMD_UNBIND = "UBND";
        public const String CMD_SECMSG = "SECMSG";
        public const String CMD_KICK = "KICK";

        public const String SERVER = "xiaomi.com";


        // 关于加密的三个方法的命名
        public const int CIPHER_NONE = 0;
        public const int CIPHER_RC4 = 1;
        public const int CIPHER_AES = 2;

        // 关于CRC校验码的长度
        public static int CRC_LEN = 4;
        internal static string RESOURCE= "Csharp";
        public const char MAGIC = (char)0xc2fe;
        public const char V6_VERSION = (char)0x0005;
        public const short HEADER_TYPE = 3;
        public const short PAYLOAD_TYPE = 2;

        public const String METHOD = "XIAOMI-PASS";
        public const String NO_KICK = "0";

        public const int PING_TIMEVAL_MS = 15000;
        public const int CONNECT_TIMEOUT = 5000;
        public const int LOGIN_TIMEOUT = 5000;
        public const int CHECK_TIMEOUT_TIMEVAL_MS = 10000;
        public const int RESET_SOCKET_TIMEOUT_TIMEVAL_MS = 5000;

        public const string MIMC_C2S_DOUBLE_DIRECTION = "C2S_DOUBLE_DIRECTION";
        public const string MIMC_C2S_SINGLE_DIRECTION = "C2S_SINGLE_DIRECTION";

        public const String FE_URL = "app.chat.xiaomi.net";
        public const int FE_PORT = 80;

        public const String FE_URL_STAGING = "10.38.162.117";
        public const int FE_PORT_STAGING = 5222;

        public static int MIMC_MAX_PACKET_SIZE =10240;
    }
}
