﻿//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace HouseholdLedger
{
    #region コンテキスト
    
    /// <summary>
    /// 使用できるメタデータ ドキュメントはありません。
    /// </summary>
    public partial class HLDContainer : ObjectContext
    {
        #region コンストラクター
    
        /// <summary>
        /// アプリケーション構成ファイルの 'HLDContainer' セクションにある接続文字列を使用して新しい HLDContainer オブジェクトを初期化します。
        /// </summary>
        public HLDContainer() : base("name=HLDContainer", "HLDContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 新しい HLDContainer オブジェクトを初期化します。
        /// </summary>
        public HLDContainer(string connectionString) : base(connectionString, "HLDContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 新しい HLDContainer オブジェクトを初期化します。
        /// </summary>
        public HLDContainer(EntityConnection connection) : base(connection, "HLDContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 部分メソッド
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet プロパティ
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        public ObjectSet<TExpense> TExpenses
        {
            get
            {
                if ((_TExpenses == null))
                {
                    _TExpenses = base.CreateObjectSet<TExpense>("TExpenses");
                }
                return _TExpenses;
            }
        }
        private ObjectSet<TExpense> _TExpenses;

        #endregion
        #region AddTo メソッド
    
        /// <summary>
        /// TExpenses EntitySet に新しいオブジェクトを追加するための非推奨のメソッドです。代わりに、関連付けられている ObjectSet&lt;T&gt; プロパティの .Add メソッドを使用してください。
        /// </summary>
        public void AddToTExpenses(TExpense tExpense)
        {
            base.AddObject("TExpenses", tExpense);
        }

        #endregion
    }
    

    #endregion
    
    #region エンティティ
    
    /// <summary>
    /// 使用できるメタデータ ドキュメントはありません。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HLD", Name="TExpense")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TExpense : EntityObject
    {
        #region ファクトリ メソッド
    
        /// <summary>
        /// 新しい TExpense オブジェクトを作成します。
        /// </summary>
        /// <param name="id">ID プロパティの初期値。</param>
        /// <param name="date">Date プロパティの初期値。</param>
        /// <param name="item">Item プロパティの初期値。</param>
        /// <param name="type">Type プロパティの初期値。</param>
        /// <param name="amount">Amount プロパティの初期値。</param>
        /// <param name="payee">Payee プロパティの初期値。</param>
        /// <param name="who">Who プロパティの初期値。</param>
        /// <param name="delFlg">DelFlg プロパティの初期値。</param>
        public static TExpense CreateTExpense(global::System.Int32 id, global::System.DateTime date, global::System.String item, global::System.Int32 type, global::System.Decimal amount, global::System.String payee, global::System.String who, global::System.Int32 delFlg)
        {
            TExpense tExpense = new TExpense();
            tExpense.ID = id;
            tExpense.Date = date;
            tExpense.Item = item;
            tExpense.Type = type;
            tExpense.Amount = amount;
            tExpense.Payee = payee;
            tExpense.Who = who;
            tExpense.DelFlg = delFlg;
            return tExpense;
        }

        #endregion
        #region プリミティブ プロパティ
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Item
        {
            get
            {
                return _Item;
            }
            set
            {
                OnItemChanging(value);
                ReportPropertyChanging("Item");
                _Item = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Item");
                OnItemChanged();
            }
        }
        private global::System.String _Item;
        partial void OnItemChanging(global::System.String value);
        partial void OnItemChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Type
        {
            get
            {
                return _Type;
            }
            set
            {
                OnTypeChanging(value);
                ReportPropertyChanging("Type");
                _Type = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Type");
                OnTypeChanged();
            }
        }
        private global::System.Int32 _Type;
        partial void OnTypeChanging(global::System.Int32 value);
        partial void OnTypeChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Payee
        {
            get
            {
                return _Payee;
            }
            set
            {
                OnPayeeChanging(value);
                ReportPropertyChanging("Payee");
                _Payee = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Payee");
                OnPayeeChanged();
            }
        }
        private global::System.String _Payee;
        partial void OnPayeeChanging(global::System.String value);
        partial void OnPayeeChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Who
        {
            get
            {
                return _Who;
            }
            set
            {
                OnWhoChanging(value);
                ReportPropertyChanging("Who");
                _Who = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Who");
                OnWhoChanged();
            }
        }
        private global::System.String _Who;
        partial void OnWhoChanging(global::System.String value);
        partial void OnWhoChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                OnCreationDateChanging(value);
                ReportPropertyChanging("CreationDate");
                _CreationDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreationDate");
                OnCreationDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreationDate;
        partial void OnCreationDateChanging(Nullable<global::System.DateTime> value);
        partial void OnCreationDateChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> UpdatedDate
        {
            get
            {
                return _UpdatedDate;
            }
            set
            {
                OnUpdatedDateChanging(value);
                ReportPropertyChanging("UpdatedDate");
                _UpdatedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UpdatedDate");
                OnUpdatedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _UpdatedDate;
        partial void OnUpdatedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnUpdatedDateChanged();
    
        /// <summary>
        /// 使用できるメタデータ ドキュメントはありません。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DelFlg
        {
            get
            {
                return _DelFlg;
            }
            set
            {
                OnDelFlgChanging(value);
                ReportPropertyChanging("DelFlg");
                _DelFlg = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DelFlg");
                OnDelFlgChanged();
            }
        }
        private global::System.Int32 _DelFlg;
        partial void OnDelFlgChanging(global::System.Int32 value);
        partial void OnDelFlgChanged();

        #endregion
    
    }

    #endregion
    
}
