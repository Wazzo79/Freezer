namespace Gecko.WebIDL
{
    using System;
    
    
    internal class TextTrackList : WebIDLBase
    {
        
        public TextTrackList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports GetTrackById(string id)
        {
            return this.CallMethod<nsISupports>("getTrackById", id);
        }
        
        public nsISupports MediaElement
        {
            get
            {
                return this.GetProperty<nsISupports>("mediaElement");
            }
        }
    }
}
