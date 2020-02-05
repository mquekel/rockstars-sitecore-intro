using Sitecore.Pipelines.RenderField;

namespace Website.Pipelines.RenderField
{
    public class AddEmoticon
    {
        public void Process(RenderFieldArgs args)
        {
            args.Result.FirstPart = $"🤘 Rockstars 🤘 {args.Result.FirstPart}";
        }
    }
}