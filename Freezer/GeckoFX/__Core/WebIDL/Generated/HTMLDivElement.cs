namespace Gecko.WebIDL
{
    using System;
    
    
    internal class HTMLDivElement : WebIDLBase
    {
        
        public HTMLDivElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
    }
}
