using System;
using System.Windows.Forms;

namespace Lab04_Carrion
{
    public partial class Form1 : Form
    {

        // Botones
        private Button btnAddNode;
        private Button btnAddElement;
        private Button btnClearTree;
        private Button btnRemoveNode;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.TextBox txtNodeName;
        private Label lblNodeName;
        private Label lblElementName;


        public Form1()
        {
            InitializeComponent();     
            cargarDatosSRI();
            InitializeLabels();


        }

        private void cargarDatosSRI()

        {

            // Agregar el nodo del Director General
            Person directorGeneral = new Person(1, "Francisco Adri�n Briones Rugel", "Director General");
            TreeNode directorGeneralNode = CreatePersonNode(directorGeneral);
            treeView1.Nodes.Add(directorGeneralNode);

            // Agregar el nodo del Subdirector General de Cumplimiento Tributario
            Person subdirectoTributario = new Person(2, "Ricardo Daniel Flores Gallardo", "Subdirector General de Cumplimiento Tributario");
            TreeNode subdirectorNodo = CreatePersonNode(subdirectoTributario);
            treeView1.Nodes.Add(subdirectorNodo);

            // Agregar el nodo de Subdirector General de Desarrollo Organizacional
            Person subdirectoOrganizacional = new Person(3, "Juan Carlos Proa�o Cordero", "Subdirector General de Desarrollo Organizacional");
            TreeNode subdirectorNodo2 = CreatePersonNode(subdirectoOrganizacional);
            treeView1.Nodes.Add(subdirectorNodo2);

            // Agregar el nodo de Directores Nacionales
            TreeNode directoresNacionalesNode = new TreeNode("Directores Nacionales");

            // Agregar los nodos de los directores nacionales
            Person[] directoresNacionales = new Person[]
            {
            new Person(4, "Mar�a Leonor Calero Pazmi�o", "Directora Nacional Jur�dica"),
            new Person(5, "Mauro Renato Tejada Ram�n", "Director Nacional de Grandes Contribuyentes"),
            new Person(6, "Carlos Eduardo Jaramillo Totoy", "Director Nacional de Control Tributario"),
            new Person(7, "Mar�a Caridad Carrion Sol�s", "Directora Nacional de Planificaci�n y Gesti�n Estrat�gica"),
            new Person(8, "Ximena Maritza Aguilar Veintimilla", "Directora Nacional Administrativo-Financiero"),
            new Person(9, "Ver�nica Johanna Reyes Mej�a", "Directora Nacional de Talento Humano"),
            new Person(10, "Oswaldo Ramiro Espinosa Bravo", "Director Nacional de Tecnolog�a"),
            new Person(11, "Maria Fernanda Parra Astudillo", "Directora Nacional de Recaudaci�n y Asistencia al Ciudadano")
            };

            foreach (Person directorNacional in directoresNacionales)
            {
                TreeNode directorNacionalNode = CreatePersonNode(directorNacional);
                directoresNacionalesNode.Nodes.Add(directorNacionalNode);
            }

            treeView1.Nodes.Add(directoresNacionalesNode);

            // Agregar el nodo de Directores Zonales
            TreeNode directoresZonalesNode = new TreeNode("Directores Zonales");

            // Agregar los nodos de los directores zonales
            Person[] directoresZonales = new Person[]
            {
            new Person(12, "Andr�s Felipe C�rdova Pizarro", "Director Zonal 9 - Pichincha"),
            new Person(13, "Carlos Vicente Mar�n Quijije", "Director Zonal 8 - Guayas"),
            new Person(14, "Julio C�sar Ruiz Zhingre", "Director Zonal 7 - Loja"),
            new Person(15, "Mayra Ver�nica Orellana Ullauri", "Directora Zonal 6 - Azuay"),
            new Person(16, "Jean Steve Carrera L�pez", "Director Zonal 5 - Los R�os"),
            new Person(17, "Monserrate Auxiliadora Holgu�n Alvia", "Directora Zonal 4 - Manab�"),
            new Person(18, "Tarquino Fidel Pati�o Esp�n", "Director Zonal 3 - Tungurahua"),
            new Person(19, "Patricia de las Mercedes Borja Sevilla", "Directora Zonal 2 - Napo"),
            new Person(20, "Daniela Alejandra Proa�o Cruz", "Directora Zonal 1 - Imbabura")
};

            foreach (Person directorZonal in directoresZonales)
            {
                TreeNode directorZonalNode = CreatePersonNode(directorZonal);
                directoresZonalesNode.Nodes.Add(directorZonalNode);
            }

            treeView1.Nodes.Add(directoresZonalesNode);

            // Agregar el nodo de Directores Distritales
            TreeNode directoresDistritalesNode = new TreeNode("Directores Distritales");

            // Agregar los nodos de los directores distritales
            Person[] directoresDistritales = new Person[]
            {
            new Person(21, "Mar�a Elizabeth V�squez Ruiz", "Directora Distrital Bol�var"),
            new Person(22, "Milton Marcelo Merchan Matute", "Director Distrital Ca�ar"),
            new Person(23, "Marco Vinicio Almeida Lucero", "Director Distrital Carchi"),
            new Person(24, "Ana Cristina Ortega Ortega", "Directora Distrital Cotopaxi"),
            new Person(25, "Jorge Luis V�squez Altamirano", "Director Distrital Chimborazo"),
            new Person(26, "Valeria Jennifer Constante Alvarado", "Director Distrital El Oro"),
            new Person(27, "Patricio Alexander Cuesta Bueno", "Director Distrital Esmeraldas"),
            new Person(28, "M�nica Esperanza �vila Borja", "Directora Distrital Morona Santiago"),
            new Person(29, "Christian Daniel Quintana Ojeda", "Director Distrital Orellana"),
            new Person(30, "Deysi Alexandra Fonseca Jarr�n", "Directora Distrital Pastaza"),
            new Person(31, "Johnny Josu� Firmat Fari�o", "Director Distrital Santa Elena"),
            new Person(32, "Juan Carlos Mendoza �lava", "Director Distrital Santo Domingo de los Tsachilas"),
            new Person(33, "Rodolfo Franciso O�ate Huayamabe", "Director Distrital Sucumb�os"),
            new Person(34, "Guadalupe del Carmen Macas S�nchez", "Directora Distrital Zamora Chinchipe")
            };

            foreach (Person directorDistrital in directoresDistritales)
            {
                TreeNode directorDistritalNode = CreatePersonNode(directorDistrital);
                directoresDistritalesNode.Nodes.Add(directorDistritalNode);
            }

            treeView1.Nodes.Add(directoresDistritalesNode);

        }

        private void InitializeLabels()
        {
            // Configurar la etiqueta del nombre del nodo
            lblNodeName = new Label();
            lblNodeName.Text = "Nombre del Nodo:";
            lblNodeName.Location = new Point(12, 190);
            lblNodeName.AutoSize = true;

            // Configurar la etiqueta del nombre del elemento
            lblElementName = new Label();
            lblElementName.Text = "Nombre del Elemento:";
            lblElementName.Location = new Point(12, 220);
            lblElementName.AutoSize = true;

            // Agregar las etiquetas al formulario
            this.Controls.Add(lblNodeName);
            this.Controls.Add(lblElementName);
        }

        private TreeNode CreatePersonNode(Person persona)
        {
            string nodeText = $"{persona.Role} - {persona.Name}";
            TreeNode node = new TreeNode(nodeText);
            node.Tag = persona;
            return node;

        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del nodo ingresado por el usuario
            string nodeName = txtNodeName.Text;

            // Verificar si se ingres� un nombre v�lido
            if (!string.IsNullOrEmpty(nodeName))
            {
                // Obtener el nodo seleccionado actualmente
                TreeNode selectedNode = treeView1.SelectedNode;

                // Verificar si hay un nodo seleccionado
                if (selectedNode != null)
                {
                    // Crear el nuevo nodo con el nombre especificado
                    TreeNode newNode = new TreeNode(nodeName);

                    // Agregar el nuevo nodo como hijo del nodo seleccionado
                    selectedNode.Nodes.Add(newNode);
                }
                else
                {
                    // No hay un nodo seleccionado, agregar el nuevo nodo al nivel superior
                    TreeNode newNode = new TreeNode(nodeName);
                    treeView1.Nodes.Add(newNode);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre v�lido para el nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode != null && selectedNode.Parent != null)
            {
                // Obtener el nombre del elemento ingresado por el usuario
                string elementName = txtElementName.Text;

                // Verificar si se ingres� un nombre v�lido
                if (!string.IsNullOrEmpty(elementName))
                {
                    // Crear el nuevo elemento con el nombre especificado
                    TreeNode newElement = new TreeNode(elementName);

                    // Insertar el nuevo elemento en el nodo padre
                    selectedNode.Parent.Nodes.Insert(selectedNode.Index + 1, newElement);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nombre v�lido para el elemento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un nodo v�lido para agregar un elemento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClearTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != null && selectedNode.Parent != null)
            {
                selectedNode.Parent.Nodes.Remove(selectedNode);
            }
        }

        public class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }

            public Person(int id, string name, string role)
            {
                ID = id;
                Name = name;
                Role = role;
            }
        }

   
    }
}