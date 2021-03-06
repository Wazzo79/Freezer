namespace Gecko.WebIDL
{
    using System;
    
    
    internal class SVGPathSegLinetoVerticalRel : WebIDLBase
    {
        
        public SVGPathSegLinetoVerticalRel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
    }
}
