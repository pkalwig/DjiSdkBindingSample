using Android.App;

namespace DjiSdkBindingSample.App
{
    [Application]
    public class SampleApplication : Application
    {
        public override void OnCreate()
        {
            base.OnCreate();
            Com.Secneo.Sdk.Helper.Install(this);
        }
    }
}