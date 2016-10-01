using System;

namespace RobertLw.OpenGL.Windows
{

    #region Class Documentation

    /// <summary>
    ///     Injects supplied MSIL into the method's body.
    /// </summary>
    /// <remarks>
    ///     This is a hack as the C# compiler does not allow inline MSIL.  This is extracted and
    ///     the appropriate MSIL injected by the PostProcessTao utility.
    /// </remarks>

    #endregion Class Documentation
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class IlasmAttribute : Attribute
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly string msil;

        #region IlasmAttribute(string msil)

        /// <summary>
        ///     Injects the supplied MSIL into the tagged method's body.
        /// </summary>
        /// <param name="msil">
        ///     The MSIL to inject.
        /// </param>
        public IlasmAttribute(string msil)
        {
            this.msil = msil;
        }

        #endregion IlasmAttribute(string msil)
    }
}