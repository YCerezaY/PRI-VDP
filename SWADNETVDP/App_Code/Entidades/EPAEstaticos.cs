using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPAEstaticos
/// </summary>
[DataContract]
public class EPAEstaticos
{
    [DataMember]
    static public byte EstadoActiva = 1;
    [DataMember]
    static public byte EstadoInactivo = 0;
    //[DataMember]
    //static public string EstadoFinalizada = "FI";
    //[DataMember]
    //static public string EstadoValido = "VA";
    [DataMember]
    static public DateTime FechaModificacion = DateTime.Now;
    [DataMember]
    static public DateTime FechaRegistro = DateTime.Now;
    //[DataMember]
    //static public double DonacionVoto = 0;
    //[DataMember]
    //static public double CreditosUsuario = 0;
    public EPAEstaticos()
    {

    }

}