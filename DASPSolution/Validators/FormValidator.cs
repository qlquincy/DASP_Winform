using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace CommonUtil.Validators
{
    #region FormValidator

    [ToolboxBitmap(typeof(FormValidator), "FormValidator.ico")]
    public class FormValidator : Component, ISupportInitialize
    {

        #region ISupportInitialize

        public void BeginInit() { }

        public void EndInit()
        {
            if ((_hostingForm != null) && _validateOnAccept)
            {
                if (_hostingForm.AcceptButton is Button)
                {
                    Button acceptButton = (Button)_hostingForm.AcceptButton;
                    if (acceptButton != null)
                    {
                        acceptButton.Click += new EventHandler(AcceptButton_Click);
                    }
                }
            }
        }

        #endregion

        private Form _hostingForm = null;
        private bool _validateOnAccept = true;
        private string _errorMessage = "Form is not valid.";

        [Browsable(false)]
        [DefaultValue(null)]
        public Form HostingForm
        {
            get
            {
                if ((_hostingForm == null) && DesignMode)
                {
                    // See if we're being hosted in VS.NET (or something similar)
                    // Cheers Ian Griffiths/Chris Sells for this code
                    IDesignerHost designer = this.GetService(typeof(IDesignerHost)) as IDesignerHost;
                    if (designer != null) _hostingForm = designer.RootComponent as Form;
                }
                return _hostingForm;
            }
            set
            {
                if (!DesignMode)
                {
                    // Only allow this property to be set if:
                    //    a) it is being set for the first time
                    //    b) it is the same Form as the original form
                    if ((_hostingForm != null) && (_hostingForm != value))
                    {
                        throw new Exception("Can't change HostingForm at runtime.");
                    }
                    else _hostingForm = value;
                }
            }
        }

        [Category("Behavior")]
        [Description("If the host form's Accept property is set, automatically validate on click.")]
        [DefaultValue(true)]
        public bool ValidateOnAccept
        {
            get { return _validateOnAccept; }
            set { _validateOnAccept = value; }
        }

        [Category("Behavior")]
        [Description("Specifies the error message displayed to the user if the form is invalid.")]
        [DefaultValue("Form is not valid.")]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        private void AcceptButton_Click(object sender, System.EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                //_hostingForm.DialogResult = DialogResult.OK;
            }
            else
            {
                //string caption = string.Format("{0} Invalid", _hostingForm.Text);
                //MessageBox.Show(_errorMessage, caption);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsValid
        {
            get
            {
                // Get validators for this form, if any
                ValidatorCollection validators = ValidatorManager.GetValidators(_hostingForm);
                if (validators == null) return true;
                // Check validity
                foreach (BaseValidator validator in validators)
                {
                    if (validator.IsValid == false) return false;
                }
                return true;
            }
        }

        public void Validate()
        {

            // Validate all validators on this form, ensuring first invalid
            // control (in tab order) is selected
            Control firstInTabOrder = null;
            ValidatorCollection validators = ValidatorManager.GetValidators(_hostingForm);
            if (null == validators) return;
            foreach (BaseValidator validator in validators)
            {
                // Validate control
                validator.Validate();
                // Record tab order if before current recorded tab order
                if (!validator.IsValid)
                {
                    if ((firstInTabOrder == null) || (firstInTabOrder.TabIndex > validator.ControlToValidate.TabIndex))
                    {
                        firstInTabOrder = validator.ControlToValidate;
                    }
                }
            }
            // Select first invalid control in tab order, if any
            if (firstInTabOrder != null)
            {
                firstInTabOrder.Focus();
                if (firstInTabOrder is TextBoxBase)
                {
                    TextBoxBase textbox = firstInTabOrder as TextBoxBase;
                    textbox.SelectionStart = 0;
                    textbox.SelectionLength = textbox.Text.Length;
                }
            }
        }
    }

    #endregion
}
