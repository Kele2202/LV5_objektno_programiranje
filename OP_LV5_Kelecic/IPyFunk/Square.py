import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'square'

def squareFunction(sender, e):
    frm = sender.Tag
    frm.tbC.Text = str((float(frm.tbA.Text)) * (float(frm.tbA.Text)))

def DodajFunkciju(frm):
    operacija = ToolStripMenuItem(Text='Square', Name='runSquare', Size=Size(130, 25))
    operacija.Tag = frm
    operacija.Click += squareFunction
    frm.addedOperaionsToolStripMenuItem.DropDownItems.Add(operacija)