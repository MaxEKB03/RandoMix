using System;
using System.Collections.Generic;
using System.Text;

namespace RandoMix
{
    class Resize
    {
        int panelWidth, panelHeight;

/*        public dynamic[] components;
        public double[] percents;
*/
        public void DoIt(System.Windows.Forms.Panel panel, dynamic[] components, double[] percents, int space, string orientation)
        {
            if (components.Length != percents.Length) { return; }

            panelWidth = Convert.ToInt32(panel.Width);
            panelHeight = Convert.ToInt32(panel.Height);

            int[] spaces = new int[components.Length+1];

            if (orientation.Equals("Horizontal"))
            {
                foreach (dynamic component in components)
                {
                    component.Width = Convert.ToInt32(panelWidth * percents[Array.IndexOf(components, component)] - 2 * space);
                    component.Height = panelHeight - 2 * space;
                    if (Array.IndexOf(components, component) == 0)
                    {
                        spaces[0] = space;
                        spaces[1] = space + component.Width;
                    }
                    else
                    {
                        spaces[Array.IndexOf(components, component)] = spaces[Array.IndexOf(components, component)] + space;
                        spaces[Array.IndexOf(components, component) + 1] = spaces[Array.IndexOf(components, component)] + component.Width;
                    }
                }
                foreach (dynamic component in components)
                {
                    component.Location = new System.Drawing.Point(spaces[Array.IndexOf(components, component)], space);
                }
            }
            else if (orientation.Equals("Vertical"))
            {
                foreach (dynamic component in components)
                {
                    component.Width = panelWidth - 2 * space;
                    component.Height = Convert.ToInt32(panelHeight * percents[Array.IndexOf(components, component)] - 2 * space);
                    if (Array.IndexOf(components, component) == 0)
                    {
                        spaces[0] = space;
                        spaces[1] = space + component.Height;
                    }
                    else
                    {
                        spaces[Array.IndexOf(components, component)] = spaces[Array.IndexOf(components, component)] + space;
                        spaces[Array.IndexOf(components, component) + 1] = spaces[Array.IndexOf(components, component)] + component.Height;
                    }
                }
                foreach (dynamic component in components)
                {
                    component.Location = new System.Drawing.Point(space, spaces[Array.IndexOf(components, component)]);
                }
            }
        }
    }
}
