﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> {
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<byte[]>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Uri>(schema2);
            this._serializer3 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[4];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>[4];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationListAsync[3] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>(4);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(4);
            packOperationTableAsync["Data"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationTableAsync["History"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            packOperationTableAsync["Source"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>>(3);
            nullCheckerTable["Data"] = new System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>(this.IsDataNull);
            nullCheckerTable["History"] = new System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>(this.IsHistoryNull);
            nullCheckerTable["Source"] = new System.Func<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, bool>(this.IsSourceNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfData);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfSource);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[4];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationListAsync[3] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>>(4);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfData);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(4);
            unpackOperationTableAsync["Data"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationTableAsync["History"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            unpackOperationTableAsync["Source"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Data",
                    "History",
                    "Source",
                    "TimeStamp"};
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValueAsync);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer0.PackTo(packer, objectTree.Data);
        }
        
        private bool IsDataNull(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            return (objectTree.Data == null);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer1.PackTo(packer, objectTree.History);
        }
        
        private bool IsHistoryNull(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            return (objectTree.History == null);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer2.PackTo(packer, objectTree.Source);
        }
        
        private bool IsSourceNull(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            return (objectTree.Source == null);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfDataAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Data, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfHistoryAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.History, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfSourceAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer2.PackToAsync(packer, objectTree.Source, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfTimeStampAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer3.PackToAsync(packer, objectTree.TimeStamp, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTableAsync;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            packHelperParameters0.CancellationToken = cancellationToken;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(ref packHelperParameters);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(byte[]);
            unpackHelperParameters.MemberName = "Data";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDataDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(System.Collections.Generic.Dictionary<System.DateTime, string>);
            unpackHelperParameters0.MemberName = "History";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfHistoryDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(System.Uri);
            unpackHelperParameters1.MemberName = "Source";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = null;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfSourceDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters1);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime> unpackHelperParameters2 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime>);
            unpackHelperParameters2.Unpacker = unpacker;
            unpackHelperParameters2.UnpackingContext = unpackingContext;
            unpackHelperParameters2.Serializer = this._serializer3;
            unpackHelperParameters2.ItemsCount = itemsCount;
            unpackHelperParameters2.Unpacked = indexOfItem;
            unpackHelperParameters2.TargetObjectType = typeof(System.DateTime);
            unpackHelperParameters2.MemberName = "TimeStamp";
            unpackHelperParameters2.DirectRead = null;
            unpackHelperParameters2.Setter = this.this_SetUnpackedValueOfTimeStampDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters2);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithoutAnyAttribute UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithoutAnyAttribute result = default(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute);
            result = new MsgPack.Serialization.ComplexTypeWithoutAnyAttribute();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDataAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(byte[]);
            unpackHelperParameters.MemberName = "Data";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDataDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfHistoryAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(System.Collections.Generic.Dictionary<System.DateTime, string>);
            unpackHelperParameters0.MemberName = "History";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfHistoryDelegate;
            unpackHelperParameters0.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters0);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfSourceAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(System.Uri);
            unpackHelperParameters1.MemberName = "Source";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = null;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfSourceDelegate;
            unpackHelperParameters1.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters1);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTimeStampAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime> unpackHelperParameters2 = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime>);
            unpackHelperParameters2.Unpacker = unpacker;
            unpackHelperParameters2.UnpackingContext = unpackingContext;
            unpackHelperParameters2.Serializer = this._serializer3;
            unpackHelperParameters2.ItemsCount = itemsCount;
            unpackHelperParameters2.Unpacked = indexOfItem;
            unpackHelperParameters2.TargetObjectType = typeof(System.DateTime);
            unpackHelperParameters2.MemberName = "TimeStamp";
            unpackHelperParameters2.DirectRead = null;
            unpackHelperParameters2.Setter = this.this_SetUnpackedValueOfTimeStampDelegate;
            unpackHelperParameters2.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters2);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.ComplexTypeWithoutAnyAttribute result = default(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute);
            result = new MsgPack.Serialization.ComplexTypeWithoutAnyAttribute();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
