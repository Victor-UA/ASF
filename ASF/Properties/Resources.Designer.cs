﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASF.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASF.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap NewDocument {
            get {
                object obj = ResourceManager.GetObject("NewDocument", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на insert into ORDERS
        ///   (ORDERID,
        ///    VALID, 
        ///    GUIDHI,
        ///    GUIDLO,
        ///    PARENTID,
        ///    OWNERTYPE,
        ///    ORDERNO,
        ///    AGREEMENTNO,
        ///    AGREEMENTDATE,
        ///    CUSTOMERID,
        ///    CURRENCYID,
        ///    CROSSRATE,
        ///    SELLERID,
        ///    OWNERID,
        ///    ORDERSTATEID,
        ///    PAYTYPEID,
        ///    TOTALPRICE,
        ///    TOTALPRICELOCK,
        ///    PAYMENT,
        ///    ADRESSINSTALL,
        ///    FLOORINSTALL,
        ///    PHONEINSTALL,
        ///    DATEORDER,
        ///    RCOMMENT,
        ///    ORDERSTATUS,
        ///    LASTGENITEM,
        ///    ITEMSTATUSMODE,
        ///    LABORIOUSNESS,
        ///    PRODDATE,
        ///    ISDEA [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string qryInsertIntoOrders {
            get {
                return ResourceManager.GetString("qryInsertIntoOrders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update ORDERS set
        ///  VALID = :VALID,
        ///  GUIDHI = :GUIDHI,
        ///  GUIDLO = :GUIDLO,
        ///  PARENTID = :PARENTID,
        ///  ORDERNO = :ORDERNO,
        ///  AGREEMENTNO = :AGREEMENTNO,
        ///  AGREEMENTDATE = :AGREEMENTDATE,
        ///  CUSTOMERID = :CUSTOMERID,
        ///  CURRENCYID = :CURRENCYID,
        ///  CROSSRATE = :CROSSRATE,
        ///  SELLERID = :SELLERID,
        ///  OWNERID = :OWNERID,
        ///  ORDERSTATEID = :ORDERSTATEID,
        ///  PAYTYPEID = :PAYTYPEID,
        ///  TOTALPRICE = :TOTALPRICE,
        ///  TOTALPRICELOCK = :TOTALPRICELOCK,
        ///  PAYMENT = :PAYMENT,
        ///  ADRESSINSTALL = :ADRESSINSTALL,
        ///  [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string qryUpdateOrders {
            get {
                return ResourceManager.GetString("qryUpdateOrders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Save {
            get {
                object obj = ResourceManager.GetObject("Save", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}