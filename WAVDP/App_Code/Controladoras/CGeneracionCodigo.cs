using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

/// <summary>
/// Descripción breve de CGeneracionCodigo
/// </summary>
public class CGeneracionCodigo
{
    public static string GenerateUniqueId()
    {
        string macAddress = GetMacAddress();
        string currentDate = DateTime.Now.ToString("yyyyMMddHHmmss");
        string uniqueId = macAddress + currentDate;
        return uniqueId;
    }

    private static string GetMacAddress()
    {
        string macAddress = string.Empty;
        try
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            macAddress = networkInterfaces[0].GetPhysicalAddress().ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return macAddress;
    }
}