namespace Nop.Web.Framework.Models.DataTables
{
    /// <summary>
    /// Represents button render for DataTables column
    /// </summary>
    public partial class RenderButtonsInlineEdit : IRender
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the RenderButton class 
        /// </summary>
        public RenderButtonsInlineEdit()
        {
            Style = NopStyleButtonDefaults.Default;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets button style
        /// </summary>
        public string Style { get; set; }

        #endregion
    }
}