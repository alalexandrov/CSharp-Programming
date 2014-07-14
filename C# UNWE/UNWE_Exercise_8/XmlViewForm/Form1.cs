using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlViewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "File Path";
            label1.SetBounds(8, 8, 50, 20);
            string FilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBox1.Text = FilePath + "\\Sample.xml";
            textBox1.SetBounds(64, 8, 580, 20);
            button1.Text = "Populate the TreeView with XML";
            button1.SetBounds(658, 8, 150, 20);
            button2.Text = "Save XML";
            button2.SetBounds(658, 38, 150, 20);
            this.Text = "TreeView control from XML";
            this.Width = 836;
            this.Height = 668;
            treeView1.SetBounds(8, 72, 800, 500);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                XmlDocument dom = new XmlDocument();
                dom.Load(textBox1.Text);

                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeView1.Nodes[0];

                AddNode(dom.DocumentElement, tNode);
                treeView1.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;


            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlTextWriter writer = new XmlTextWriter(FilePath + "\\NewXmlFile.xml", Encoding.GetEncoding("utf-8"));
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = '\t';
            writer.Indentation = 1;
            try
            {
                using (writer)
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("bookstore");
                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Aleksandur Aleksandrov");
                    writer.WriteElementString("price", "12.10");
                    writer.WriteEndElement();

                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Vladimir Metrashev");
                    writer.WriteElementString("price", "33.33");
                    writer.WriteEndElement();

                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Peio Qvorov");
                    writer.WriteElementString("price", "14.14");
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteEndDocument();

                    MessageBox.Show("Файлът е записан успешно !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

