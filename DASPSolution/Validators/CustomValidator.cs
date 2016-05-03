using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

namespace CommonUtil.Validators
{
    [ToolboxBitmap(typeof(CustomValidator), "CustomValidator.ico")]
    [DefaultEvent("Validating")]
    public class CustomValidator : BaseValidator
    {
        public class ValidatingCancelEventArgs
        {
            private bool _valid;
            private Control _controlToValidate;

            public ValidatingCancelEventArgs(bool valid, Control controlToValidate)
            {
                _valid = valid;
                _controlToValidate = controlToValidate;
            }

            public bool Valid
            {
                get { return _valid; }
                set { _valid = value; }
            }
            public Control ControlToValidate
            {
                get { return _controlToValidate; }
                set { _controlToValidate = value; }
            }
        }

        public delegate void ValidatingEventHandler(object sender, ValidatingCancelEventArgs e);

        [Category("Action")]
        [Description("Occurs when the CustomValidator validates the value of the ControlToValidate property.")]
        public event ValidatingEventHandler Validating;

        public void OnValidating(ValidatingCancelEventArgs e)
        {
            if (Validating != null) Validating(this, e);
        }

        protected override bool EvaluateIsValid()
        {
            // Pass validation processing to event handler and wait for response
            ValidatingCancelEventArgs args = new ValidatingCancelEventArgs(false, this.ControlToValidate);
            OnValidating(args);
            return args.Valid;
        }
    }
}
