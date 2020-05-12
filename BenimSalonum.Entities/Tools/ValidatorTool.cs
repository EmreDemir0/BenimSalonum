using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using BenimSalonum.Entities.Interfaces;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BenimSalonum.Entities.Tools
{
    public static class ValidatorTool
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            bool result = true;
            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string messsage = null;
                foreach (var error in validationResult.Errors)
                {
                    messsage += error.ErrorMessage + System.Environment.NewLine;
                }
                XtraMessageBox.Show(messsage);
                result = false;
            }
            return result;
        }
    }
}


