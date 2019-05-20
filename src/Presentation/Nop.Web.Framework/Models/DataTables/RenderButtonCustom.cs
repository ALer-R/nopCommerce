namespace Nop.Web.Framework.Models.DataTables
{
    /// <summary>
    /// Represents button custom render for DataTables column
    /// </summary>
    public partial class RenderButtonCustom : IRender
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the RenderButtonEdit class 
        /// </summary>
        /// <param name="style">Style of button</param>
        /// <param name="title">Title button</param>
        public RenderButtonCustom(string style, string title)
        {
            Style = style;
            Title = title;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets Url to action
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets button style
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets button title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets function name on click button
        /// </summary>
        public string OnClickFunctionName { get; set; }

        #endregion
    }
}
