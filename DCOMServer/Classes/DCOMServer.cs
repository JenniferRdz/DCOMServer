using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DCOMServer.Classes
{
    // Asegúrate de que la clase sea visible para COM
    [ComVisible(true)]
    // Asigna un GUID único a la clase
    [Guid("12345678-1234-1234-1234-123456789ABC")]
    // Asegura que el servidor implementa una interfaz
    [ProgId("DCOMServer.ServerClass")]  // Esto es lo que le da el nombre al servidor
    public class DCOMServer : IServerClass
    {
        // Un método disponible para los clientes
        public string GetMessage()
        {
            return "Hola desde el servidor DCOM!";
        }
    }

    // Define una interfaz COM que será expuesta
    [ComVisible(true)]
    [Guid("23456789-1234-1234-1234-123456789ABC")]
    public interface IServerClass
    {
        string GetMessage();
    }
}
