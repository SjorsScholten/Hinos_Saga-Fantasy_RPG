namespace Util {
    public interface IPresenter<in TType>{
        void UpdateGUI(TType source);
    }
}