﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using AnyStatus.API;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace AnyStatus.Plugins.Widgets.GitHub
{
    /// <summary>
    /// GitHub Issue Widget.
    /// </summary>
    [Browsable(false)]
    [DisplayColumn("GitHub")]
    [DisplayName("GitHub Issue")]
    [Description("GitHub repository issue.")]
    public class GitHubIssueWidget : Widget, IWebPage
    {
        [ReadOnly(true)]
        [Required]
        [PropertyOrder(1)]
        [Category("GitHub")]
        [Description("Required. The GitHub repository owner name.")]
        public string Owner { get; set; }

        [ReadOnly(true)]
        [Required]
        [PropertyOrder(2)]
        [Category("GitHub")]
        [Description("Required. The GitHub repository name.")]
        public string Repository { get; set; }

        [ReadOnly(true)]
        [PropertyOrder(3)]
        [Category("GitHub")]
        [DisplayName("Issue")]
        [Description("Optional. The GitHub issue number.")]
        public int Issue { get; set; }

        [XmlIgnore]
        [Browsable(false)]
        public string URL { get; set; }
    }
}
