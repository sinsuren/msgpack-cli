﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_EnumUInt32FlagsSerializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumUInt32Flags> {
        
        public MsgPack_Serialization_EnumUInt32FlagsSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumUInt32Flags enumValue) {
            packer.Pack(((uint)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumUInt32Flags UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumUInt32Flags)(messagePackObject.AsUInt32()));
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
