using System.Drawing;
using System.Windows.Forms;

namespace MessageLogs
{
    public class Cell
    {
        public GroupBox gbCell;
        public Label lbUserName;
        public RichTextBox rtbMessage;

        public void UpdateAlignment(bool fromMe)
        {
            if (fromMe)
            {
                lbUserName.TextAlign = ContentAlignment.TopRight;
                rtbMessage.RightToLeft = RightToLeft.Yes;
                //lbMessage.Dock = DockStyle.Right;
            }    
            else
            {
                lbUserName.TextAlign = ContentAlignment.TopLeft;
                rtbMessage.RightToLeft= RightToLeft.No;
                //lbMessage.Dock = DockStyle.Left;
            }    
        }    
    }

    public class CellBuilder
    {
        protected Cell cell = new Cell();

        public CellBuilder()
        {
            cell.gbCell = new GroupBox();

            Label userName = new Label();
            userName.Parent = cell.gbCell;
            userName.Dock = DockStyle.Bottom;

            RichTextBox message = new RichTextBox();
            message.Parent = cell.gbCell;
            message.Dock = DockStyle.Bottom;

            cell.lbUserName = userName;
            cell.rtbMessage = message;
        }

        public CellBuilder LbUserName(string value)
        {
            cell.lbUserName.Text = value;

            return this;
        }

        public CellBuilder RtbMessage(string value)
        {
            cell.rtbMessage.Text = value; 
                
            return this;
        }    

        public static implicit operator Cell(CellBuilder cb)
        {
            return cb.cell;
        }
    }
}
