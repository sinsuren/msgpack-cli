﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> _serializer1;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndItem0;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), keysSchema0, valuesSchema0);
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            keysSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            MsgPack.Serialization.PolymorphismSchema valuesSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            valuesSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            schema1 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), keysSchema1, valuesSchema1);
            this._serializer1 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(schema1);
            this._methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndItem0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty).GetMethod("set_DictPolymorphicKeyAndItem", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>)}, null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "DictPolymorphicKeyAndItem");
            this._serializer1.PackTo(packer, objectTree.DictPolymorphicKeyAndItem);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> nullable = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
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
                    if ((result.DictPolymorphicKeyAndItem == null)) {
                        this._methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndItem0.Invoke(result, new object[] {
                                    nullable});
                    }
                    else {
                        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> enumerator = nullable.GetEnumerator();
                        System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> current;
                        try {
                            for (
                            ; enumerator.MoveNext(); 
                            ) {
                                current = enumerator.Current;
                                result.DictPolymorphicKeyAndItem.Add(current.Key, current.Value);
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
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "DictPolymorphicKeyAndItem")) {
                        System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> nullable1 = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer1.UnpackFrom(disposable0);
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
                            if ((result.DictPolymorphicKeyAndItem == null)) {
                                this._methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndItem0.Invoke(result, new object[] {
                                            nullable1});
                            }
                            else {
                                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> enumerator0 = nullable1.GetEnumerator();
                                System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> current0;
                                try {
                                    for (
                                    ; enumerator0.MoveNext(); 
                                    ) {
                                        current0 = enumerator0.Current;
                                        result.DictPolymorphicKeyAndItem.Add(current0.Key, current0.Value);
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
