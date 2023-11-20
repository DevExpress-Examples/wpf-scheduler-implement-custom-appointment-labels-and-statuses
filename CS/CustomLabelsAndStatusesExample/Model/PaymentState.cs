using DevExpress.Mvvm.POCO;
using System.Windows.Media;

namespace CustomLabelsAndStatusesExample {
    public class PaymentState {
        public static PaymentState Create() {
            return ViewModelSource.Create(() => new PaymentState());
        }

        protected PaymentState() { }
        public virtual int Id { get; set; }
        public virtual string Caption { get; set; }
        public virtual Brush Brush { get; set; }
    }
}
