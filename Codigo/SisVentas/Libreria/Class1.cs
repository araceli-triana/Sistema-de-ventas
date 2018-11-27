using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Libreria
{
    public class Utilizar
    {
        //metodo ejcutar para utilizarlo siempre que se mande llamar
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = SistemaV; Integrated Security = True");
            Con.Open();//ABRIR CONEXION DE FORMA LOCAL A LA BASE DE DATOS           NOMBRE DE BD, ACCESO SIN CONTRASEÑA.

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, Con);

            dp.Fill(ds);
            Con.Close();
            return ds;
        }
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;

            foreach(Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;
                    if (Obj.Validar == true)
                    {
                        if(string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            errorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    /*else
                    {
                        errorProvider.SetError(Obj, "");
                    }*/
                    if(Obj.SoloNumeros==true)
                    {
                        int contador = 0, LetrasEncontradas = 0;
                        
                        foreach(char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(),contador))
                            {
                                LetrasEncontradas++;
                            }
                            contador++;
                        }
                        if(LetrasEncontradas !=0)
                        {
                            HayErrores = true;
                            errorProvider.SetError(Obj, "Solo Numeros");
                        }
                           
                    }
                }
            }
            return HayErrores;
        }
    }
}
