using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace CommonUtil.Validators
{
    public class ValidatorManager
    {
        private static Hashtable _validators = new Hashtable();
        // TODO:
        //private static Dictionary<Form, ValidatorCollection> validators = new Dictionary<Form, ValidatorCollection>();

        public static void Register(BaseValidator validator, Form hostingForm)
        {

            // Create form bucket if it doesn't exist
            if (_validators[hostingForm] == null)
            {
                _validators[hostingForm] = new ValidatorCollection();
            }

            // Add this validator to the list of registered validators
            ValidatorCollection validators =
              (ValidatorCollection)_validators[hostingForm];
            validators.Add(validator);
        }

        public static ValidatorCollection GetValidators(Form hostingForm)
        {
            return (ValidatorCollection)_validators[hostingForm];
        }

        public static void DeRegister(BaseValidator validator, Form hostingForm)
        {
            // Remove this validator from the list of registered validators
            ValidatorCollection validators = (ValidatorCollection)_validators[hostingForm];
            validators.Remove(validator);

            // Remove form bucket if all validators on the form are de-registered
            if (validators.Count == 0) _validators.Remove(hostingForm);
        }
    }
}
