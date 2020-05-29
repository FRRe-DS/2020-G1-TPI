using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Tools
{
    public static class Tools
    {
        public static string ExceptionMessage(Exception e)
        {
            string message = e.Message;
            while (e.InnerException != null)
            {
                e = e.InnerException;
                message = message + " -*- " + e.Message;
            };


            return message;

        }

        public static string TraduceError(Exception ex)
        {
            string errorMessage = "";

            if (ex.Message.ToUpper().Contains("FAILED TO CONNECT TO"))
            {
                errorMessage = "Se ha perdido la conexion a Internet";
            }
            else if (ex.Message.ToUpper().Contains("A TASK WAS CANCELED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else if (ex.Message.ToUpper().Contains("INTENTO DE LOGIN NO VALIDO"))
            {
                errorMessage = "Email o Contraseña NO VALIDOS";
            }
            else if (ex.Message.ToUpper().Contains("THE OPERATION WAS CANCELED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else if (ex.Message.ToUpper().Contains("SOCKET CLOSED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else
            {
                errorMessage = ex.Message;
            }

            return errorMessage;

        }

    }
}
