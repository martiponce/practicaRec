using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace practicaRec
{
    class trabajadores
    {
        string cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        private int Trabajadores;

        public int trabajador
        {
            get { return Trabajadores; }
            set { Trabajadores = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int trabaja;

        public int Trabaja
        {
            get { return trabaja; }
            set { trabaja = value; }
        }

        private int nacio;

        public int Nacio
        {
            get { return nacio; }
            set { nacio = value; }
        }

        private int BarrioID;

        public int barrioID
        {
            get { return BarrioID; }
            set { BarrioID = value; }
        }




        public trabajadores()
        {
            cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data Source=Trabajadores.mdb; Persist Security Info=False;";
             

            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Personas";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();

            adaptador.Fill(tabla);

            //la clave principal de esta tabla 
            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["personasID"];
            tabla.PrimaryKey = vec;
        }

        public void grabar()
        {
            DataRow filaExistente = tabla.Rows.Find(trabajador);

            if (filaExistente != null)
            {
                Console.WriteLine("Ya existe ese Trabajador");
                // Aquí puedes mostrar un mensaje de error en la interfaz gráfica si es una aplicación con GUI
            }
            else
            {
                DataRow fila = tabla.NewRow();
                fila["personasID"] = trabajador;
                fila["nombre"] = nombre;
                fila["sexo"] = sexo;
                fila["trabaja"] = trabaja;
                fila["nacio"] = nacio;
                fila["barrioID"] = barrioID;
                tabla.Rows.Add(fila);

                // Actualizar la base de datos con la nueva fila
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
        }

        public void eliminar()
        {
            DataRow fila = tabla.Rows.Find(trabajador);

            if (fila != null)
            {
                fila.Delete();
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }

        }
        public void modificar(int personasID, string nuevoNombre, string nuevoSexo, int nuevoTrabaja, int nuevoNacio, int nuevoBarrioID)
        {
            DataRow fila = tabla.Rows.Find(personasID);

            if (fila != null)
            {
                fila.BeginEdit();

                fila["nombre"] = nuevoNombre;
                fila["sexo"] = nuevoSexo;
                fila["trabaja"] = nuevoTrabaja;
                fila["nacio"] = nuevoNacio;
                fila["barrioID"] = nuevoBarrioID;

                fila.EndEdit();

                // Actualizar la base de datos con los cambios
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                Console.WriteLine("No se encontró el registro con personasID: " + personasID);
            }
        }

        public void buscar(int personasID, TextBox nombreTextBox, RadioButton femeninoRadioButton, RadioButton masculinoRadioButton, CheckBox trabajaCheckBox)
        {
            string consulta = "SELECT * FROM Personas WHERE personasID = @id";

            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", personasID);

                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Autocompletar los campos con los datos obtenidos de la consulta
                        nombreTextBox.Text = reader["nombre"].ToString();

                        string sexo = reader["sexo"].ToString();
                        if (sexo == "F")
                        {
                            femeninoRadioButton.Checked = true;
                            masculinoRadioButton.Checked = false;
                        }
                        else if (sexo == "M")
                        {
                            femeninoRadioButton.Checked = false;
                            masculinoRadioButton.Checked = true;
                        }

                        int trabaja = Convert.ToInt32(reader["trabaja"]);
                        trabajaCheckBox.Checked = (trabaja == 1);
                    }
                    else
                    {
                        // Mostrar un mensaje si no se encuentra el trabajador con el personasID especificado
                        Console.WriteLine("No se encontró ningún trabajador con ese personasID");
                        // Aquí puedes manejar el mensaje de error en la interfaz gráfica si es una aplicación con GUI
                    }

                    reader.Close();
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine("Error al buscar en la base de datos: " + ex.Message);
                    // Manejo de error: puedes mostrar un mensaje en la interfaz gráfica si es una aplicación con GUI
                }
            }
        }



    }
}
