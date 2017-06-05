using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTools;

namespace CRMsales2
{
    public partial class ProductForm : Form
    {
        TreeListView Tree;
        List<Product> Products;
        List<Product> BufferProducts;

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        void AddToTree(int ProductCategoryID/*-передаем для того что бы сохранить ID-ки старой базы*/, Node parent)
        {
            foreach (var i in Products.Where(a => a.ProductCategory == ProductCategoryID).OrderBy(a=>a.OrderPosition))
            {
                Node NewNode = parent.Nodes.Add(i.Name);

                if (i.Price != 0)
                {
                  
                    NewNode["Цена"] = i.Price;
                    NewNode["Остаток"] = i.Amount;
                    NewNode["Ед.изм."] = i.Unit.Name;
                }
                NewNode["Id"] = i.ID;

                //if (i.Amount )


                AddToTree(i.ID, NewNode);
            }
        }


        public ProductForm()
        {
            InitializeComponent();
          
            BufferProducts = new List<Product>();
            Tree = new TreeListView();

            Tree.Dock = DockStyle.Left;
            panelTree.Controls.Add(Tree);

            Tree.AllowDrop = true;
            Tree.MouseMove += Tree_MouseMove;
            Tree.MouseDown += Tree_MouseDown;
            Tree.DragOver += Tree_DragOver;
            Tree.DragDrop += Tree_DragDrop;
            Tree.AfterSelect += Tree_AfterSelect;



            Tree.Columns.Add(new TreeListColumn("Категория/Название"));
            Tree.Columns["Категория/Название"].Width = 300;
            Tree.Columns["Категория/Название"].Caption = "Категория/Название";
            Tree.Columns.Add(new TreeListColumn("Цена"));
            Tree.Columns["Цена"].Width = 50;
            Tree.Columns["Цена"].Caption = "Цена";
            Tree.Columns.Add(new TreeListColumn("Остаток"));
            Tree.Columns["Остаток"].Width = 20;
            Tree.Columns["Остаток"].Caption = "Остаток";
            Tree.Columns.Add(new TreeListColumn("Ед.изм."));
            Tree.Columns["Ед.изм."].Width = 20;
            Tree.Columns["Ед.изм."].Caption = "Ед.изм.";
            Tree.Columns.Add(new TreeListColumn("Id"));
            Tree.Columns["Id"].VisibleIndex = -1;

            BuildTree();

            //Node parent = Tree.Nodes.Add("qweqweqwe");
            //parent.Nodes.Add("Подэлемент");
            //Tree.Nodes.Add("qweqweqwe");
            //Tree.Nodes.Add("qweqweqwe");

            Tree.Width = 1000;
            button1.Enabled = false;
            button2.Enabled = false;
            //CommonTools.TreeListColumn treeListColumn1 = new CommonTools.TreeListColumn("folder", "Folder");
            //CommonTools.TreeListColumn treeListColumn2 = new CommonTools.TreeListColumn("createdTime", "Date Created");
            //CommonTools.TreeListColumn treeListColumn3 = new CommonTools.TreeListColumn("size", "Size");

            //Tree.Columns.AddRange(new CommonTools.TreeListColumn[] {
            //treeListColumn1,
            //treeListColumn2,
            //treeListColumn3});

            //treeListColumn1.Width = 250;
            //treeListColumn2.CellFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            //treeListColumn2.CellFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            //treeListColumn2.CellFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            //treeListColumn2.Width = 130;
            //treeListColumn3.CellFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            //treeListColumn3.HeaderFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            //treeListColumn3.Width = 100;

            //Tree.Images = null;
            //Tree.Location = new System.Drawing.Point(3, 3);
            //Tree.Name = "m_folderTree";
            //Tree.Size = new System.Drawing.Size(471, 326);
            //Tree.TabIndex = 0;
            //Tree.Text = "treeListView1";
            //Tree.ViewOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Tree.RowOptions.ItemHeight = 30;

            //CommonTools.Node parent = Tree.Nodes.Add("asdasd");

            //parent.Nodes.Add("asdasdasdsa");
            //parent.Nodes.Add("kjhjhkjkjhkj");
            //CommonTools.Node parent2 = Tree.Nodes.Add("kjkjjkkj2");

            //CommonTools.Node node = new CommonTools.Node(); 

            //node[0] = "asdasd";
            //node[1] = "qweqwe";
            //node[2] = "zxczxc";
            //Tree.Nodes.Add(node);
            //CommonTools.Node node2 = new CommonTools.Node();

            //node2[0] = "asdasd2";
            //node2[1] = "qweqwe2";
            //node2[2] = "zxczxc2";
            //Tree.Nodes.Add(node2);

            //Aga.Controls.Tree.TreeViewAdv Tree = new Aga.Controls.Tree.TreeViewAdv();

            //this.Controls.Add(Tree);
            //Tree.Dock = DockStyle.Fill;
            //Tree.Columns.Add(new Aga.Controls.Tree.TreeColumn("asdasd", 400));
            //Tree.NodeControls.Add(new Aga.Controls.Tree.NodeControls.NodeTextBox());
        }

        private void BuildTree()
        {
            Tree.Nodes.Clear();
            Products = Product.GetAll().ToList();
            foreach (var i in Products.Where(a => a.ProductCategory == 0))
            {
                Node parent = Tree.Nodes.Add(i.Name);
                parent["Id"] = i.ID;
                AddToTree(i.ID, parent);

            }
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
            if (Tree.NodesSelection.Count == 1 && dataGridView1.SelectedRows.Count > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

            if (Tree.NodesSelection.Count  > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Tree_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = Tree.PointToClient(new Point(e.X, e.Y));



            // Get the row index of the item the mouse is below. 
            //rowIndexOfItemUnderMouseToDrop =
            //    Tree.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            rowIndexOfItemUnderMouseToDrop = Tree.GetHitNode().NodeIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                Tree.Nodes.Remove(Tree.Nodes[rowIndexFromMouseDown]);
               // Tree.Nodes.InsertAfter(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

        private void Tree_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Tree_MouseDown(object sender, MouseEventArgs e)
        {
            //Нужно уйти от использования индексов выбранной строки в пользу вершины (NODE)


            // Get the index of the item the mouse is below.
            // rowIndexFromMouseDown = Tree.HitTest(e.X, e.Y).RowIndex;
            if (Tree.NodesSelection.Count == 0) return;
            rowIndexFromMouseDown = Tree.NodesSelection[0].NodeIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void Tree_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = Tree.DoDragDrop(
                    Tree.Nodes[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            //Перебираем выбранные вершины в дереве
            for (int i = 0; i < Tree.NodesSelection.Count; i++)
            {
                //1. Tree.NodesSelection[i]["Id"] - Обращаемся к i-ой выбранной вершине дерева. Вершина - это строка состаящая из столбцов. Нам нужен столбец Id
                //2. Полученный в предыдущем действии ID получился типа object (неопределённый тип). Поэтому, приводим его к int
                //3. C помощью linq находим товар с таким id  и добавляем в список-буфер товаров
                BufferProducts.Add(Products.Where(a => a.ID == Convert.ToInt32(Tree.NodesSelection[i]["Id"])).FirstOrDefault());

                if (Tree.NodesSelection[i].Parent != null) // Если у удаляемой вершины есть родитель
                {
                    //Tree.NodesSelection[i] - обращаемся к i-ой выбранной вершине (строке) дерева, её же нужно удалить.
                    //Для этого обращаемся к её родителю. Через родителя обращаемся к списку его наследников. 
                    //Методу Remove передаём адрес удаляемого объекта в списке наследников родителя. 
                    Tree.NodesSelection[i].Parent.Nodes.Remove(Tree.NodesSelection[i]);
                }
                else //Иначе, означает что родителя нет. То есть удаляется элемент с самого верхнего уровня. 
                {
                    Tree.Nodes.Remove(Tree.NodesSelection[i]);
                }
            }

            Tree.NodesSelection.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BufferProducts;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Товар
            //1. Получить выбранные объекты товаров в правом списке
            foreach (DataGridViewRow i in dataGridView1.SelectedRows)
            {
                //2. Отследить в левом списке - куда осуществляется добовление
                if (Tree.NodesSelection[0]["Цена"] == null)
                {
                    //2.1. Если добавляем в выбранную категорию
                    //      Определить товар с минимальным OrderPosition в данной категории
                    Product MinProductInGroup = Products.Where(a => a.ProductCategory == Convert.ToInt32(Tree.NodesSelection[0]["Id"])).First();
                    Product MovedProduct = BufferProducts.Where(a => a.ID == Convert.ToInt32(i.Cells[0].Value)).FirstOrDefault();
     
                    Product.SwapTwoProducts(MinProductInGroup, MovedProduct);
                    BufferProducts.Remove(MovedProduct);

                    Node parent = Tree.NodesSelection[0];
                    Node NewNode = new Node(new object[] { MovedProduct.Name, MovedProduct.Price, MovedProduct.Amount, MovedProduct.Unit.Name, MovedProduct.ID });

                    //Стоит задача вставлять товар в начала категории
                    //Но есть только метод InsertAfter (виснет?)
                    //Решение - вставить новый товар после первого
                    //После него вставить копию первого товара
                    //Удалить первый товар

                    //   parent.Nodes.InsertAfter(NewNode, parent.Nodes[0]);
                    // parent.Nodes.InsertAfter(parent.Nodes[0], NewNode);
                    //  parent.Nodes.Remove(parent.Nodes[0]);




                    //if (MovedProduct.Price != 0)
                    //{

                    //    NewNode["Цена"] =;
                    //    NewNode["Остаток"] = ;
                    //    NewNode["Ед.изм."] = ;
                    //}
                    //NewNode["Id"] = 

                    //Products = Product.GetAll().ToList();
                    //      Выполнить обновление OrderPosition выбранного в правой таблице товара со смещением всех больших OrderPosition на 1. 
                }
                else
                {
                    MessageBox.Show("Выбрана товар");
                    //Добавление товара между другими товарами
                }

            }
            //Категорию

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BufferProducts;

            //BuildTree();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Tree.NodesSelection.Count == 1 && dataGridView1.SelectedRows.Count > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

            if (Tree.NodesSelection.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
