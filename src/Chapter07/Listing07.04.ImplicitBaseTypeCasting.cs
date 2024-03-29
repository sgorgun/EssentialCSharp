﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_04
{
    using Listing07_03;

    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            // Derived types can be implicitly converted to
            // base types
            Contact contact = new Contact();
            #region HIGHLIGHT
            PdaItem item = contact;
            #endregion
            // ...

            // Base types must be cast explicitly to derived types
            #region HIGHLIGHT
            contact = (Contact)item;
            #endregion
            // ...
        }
    }
    #endregion
}
