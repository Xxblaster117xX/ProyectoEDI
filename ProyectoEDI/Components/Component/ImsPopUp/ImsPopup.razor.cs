using DevExpress.Blazor;

namespace ProyectoEDI.Components.Component.ImsPopUp
{
    public class ImsPopup : DxPopup
    {
        public ImsPopup() : base() { }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            
            this.ShowFooter = true;
            this.Visible = false;
            this.CloseOnEscape = true;
            this.CloseOnOutsideClick = false;
            this.AllowDrag = true;
            this.AllowResize = true;
            this.Scrollable = true;
        }
    }
}
