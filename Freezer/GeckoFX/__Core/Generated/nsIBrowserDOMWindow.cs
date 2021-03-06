// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIBrowserDOMWindow.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e774db14-79ac-4156-a7a3-aa3fd0a22c10")]
	internal interface nsIOpenURIInFrameParams
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrerAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReferrer);
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReferrer);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsPrivateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsPrivateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsPrivate);
	}
	
	/// <summary>
    /// The C++ source has access to the browser script source through
    /// nsIBrowserDOMWindow. It is intended to be attached to the chrome DOMWindow
    /// of a toplevel browser window (a XUL window). A DOMWindow that does not
    /// happen to be a browser chrome window will simply have no access to any such
    /// interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31da1ce2-aec4-4c26-ac66-d622935c3bf4")]
	internal interface nsIBrowserDOMWindow
	{
		
		/// <summary>
        /// Load a URI
        /// @param aURI the URI to open. null is allowed.  If null is passed in, no
        /// load will be done, though the window the load would have
        /// happened in will be returned.
        /// @param aWhere see possible values described above.
        /// @param aOpener window requesting the open (can be null).
        /// @param aContext the context in which the URI is being opened. This
        /// is used only when aWhere == OPEN_DEFAULTWINDOW.
        /// @return the window into which the URI was opened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aOpener, short aWhere, short aContext);
		
		/// <summary>
        /// As above, but return the nsIFrameLoaderOwner for the new window.
        ///   // XXXbz is this the right API?
        ///   // See bug 537428
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OpenURIInFrame([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIOpenURIInFrameParams @params, short aWhere, short aContext);
		
		/// <summary>
        /// @param  aWindow the window to test.
        /// @return whether the window is the main content window for any
        /// currently open tab in this toplevel browser window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsTabContentWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// This function is responsible for calling
        /// nsIContentViewer::PermitUnload on each frame in the window. It
        /// returns true if closing the window is allowed. See canClose() in
        /// BrowserUtils.jsm for a simple implementation of this method.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanClose();
	}
	
	/// <summary>nsIBrowserDOMWindowConsts </summary>
	internal class nsIBrowserDOMWindowConsts
	{
		
		// <summary>
        // Do whatever the default is based on application state, user preferences,
        // and the value of the aContext parameter to openURI.
        // </summary>
		public const short OPEN_DEFAULTWINDOW = 0;
		
		// <summary>
        // Open in the "current window".  If aOpener is provided, this should be the
        // top window in aOpener's window hierarchy, but exact behavior is
        // application-dependent.  If aOpener is not provided, it's up to the
        // application to decide what constitutes a "current window".
        // </summary>
		public const short OPEN_CURRENTWINDOW = 1;
		
		// <summary>
        // Open in a new window.
        // </summary>
		public const short OPEN_NEWWINDOW = 2;
		
		// <summary>
        // Open in a new content tab in the toplevel browser window corresponding to
        // this nsIBrowserDOMWindow.
        // </summary>
		public const short OPEN_NEWTAB = 3;
		
		// <summary>
        // Open in an existing content tab based on the URI. If a match can't be
        // found, revert to OPEN_NEWTAB behavior.
        // </summary>
		public const short OPEN_SWITCHTAB = 4;
		
		// <summary>
        // external link (load request from another application, xremote, etc).
        // </summary>
		public const short OPEN_EXTERNAL = 1;
		
		// <summary>
        // internal open new window
        // </summary>
		public const short OPEN_NEW = 2;
	}
}
