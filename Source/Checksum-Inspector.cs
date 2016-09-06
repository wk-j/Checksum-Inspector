using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checksum_Inspector
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class Class1 : SharpContextMenu
    {    
        protected override bool CanShowMenu()
        {
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            //Create the menu 
            ContextMenuStrip menu = new ContextMenuStrip();

            //Create the item and set name and image
            var Item_Create_chcksum = new ToolStripMenuItem
            {
                Text = "Checksum-Inspector",
                Image = Properties.Resources.Checksum_Inspector_Logo3_finish_klein
            };

            //Create click event for the item
            Item_Create_chcksum.Click += (sender, args) => Creat_checksum();

            //Add item to the menu
            menu.Items.Add(Item_Create_chcksum);
                                 
            //Show menu               
            return menu;
        }        

        private void Creat_checksum()
        {
            string FilePath = "";            

            foreach (var item in SelectedItemPaths)
            {
                FilePath = item.ToString();
            }

            Checksum_InspectorUI Md5Gui = new Checksum_InspectorUI(FilePath);
            Md5Gui.ShowDialog();
        }        
    }
}
