using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
[DataContract]
public class SBaseDatos
{
    [DataMember]
    public static Database BDSWADVDP = DatabaseFactory.CreateDatabase("VentaDeProductosConnectionString3");
}