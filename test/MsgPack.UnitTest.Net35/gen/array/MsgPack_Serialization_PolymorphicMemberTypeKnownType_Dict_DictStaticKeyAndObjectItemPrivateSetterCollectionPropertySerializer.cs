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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, object>> _serializer0;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty_set_DictStaticKeyAndObjectItem0;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> valuesSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            valuesSchemaTypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            valuesSchemaTypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            valuesSchemaTypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object), valuesSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, object>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, object>>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty_set_DictStaticKeyAndObjectItem0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty).GetMethod("set_DictStaticKeyAndObjectItem", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<string, object>)}, null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty objectTree) {
            packer.PackArrayHeader(1);
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndObjectItem);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Collections.Generic.IDictionary<string, object> nullable = default(System.Collections.Generic.IDictionary<string, object>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer0.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer0.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    if ((result.DictStaticKeyAndObjectItem == null)) {
                        this._methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty_set_DictStaticKeyAndObjectItem0.Invoke(result, new object[] {
                                    nullable});
                    }
                    else {
                        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = nullable.GetEnumerator();
                        System.Collections.Generic.KeyValuePair<string, object> current;
                        try {
                            for (
                            ; enumerator.MoveNext(); 
                            ) {
                                current = enumerator.Current;
                                result.DictStaticKeyAndObjectItem.Add(current.Key, current.Value);
                            }
                        }
                        finally {
                            enumerator.Dispose();
                        }
                    }
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "DictStaticKeyAndObjectItem")) {
                        System.Collections.Generic.IDictionary<string, object> nullable1 = default(System.Collections.Generic.IDictionary<string, object>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer0.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer0.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable1 == null) 
                                    == false)) {
                            if ((result.DictStaticKeyAndObjectItem == null)) {
                                this._methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndObjectItemPrivateSetterCollectionProperty_set_DictStaticKeyAndObjectItem0.Invoke(result, new object[] {
                                            nullable1});
                            }
                            else {
                                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator0 = nullable1.GetEnumerator();
                                System.Collections.Generic.KeyValuePair<string, object> current0;
                                try {
                                    for (
                                    ; enumerator0.MoveNext(); 
                                    ) {
                                        current0 = enumerator0.Current;
                                        result.DictStaticKeyAndObjectItem.Add(current0.Key, current0.Value);
                                    }
                                }
                                finally {
                                    enumerator0.Dispose();
                                }
                            }
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
            }
            return result;
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
