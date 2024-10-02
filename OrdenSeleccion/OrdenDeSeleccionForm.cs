using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrupoD.Prototipos.Pampazon.OrdenSeleccion;

namespace GrupoD.Prototipos.Pampazon;

public partial class OrdenDeSeleccionForm : Form
{
    //El formulario tiene que tener una referencia al modelo.
    private OrdenSeleccionModel modelo = new();

    public OrdenDeSeleccionForm()
    {
        InitializeComponent();
    }
}
