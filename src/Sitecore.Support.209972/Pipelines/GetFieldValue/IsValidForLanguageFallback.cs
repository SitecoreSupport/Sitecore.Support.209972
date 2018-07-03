using Sitecore.Abstractions;
using Sitecore.DependencyInjection;
using Sitecore.Pipelines.GetFieldValue;

namespace Sitecore.Support.Pipelines.GetFieldValue
{
  public class IsValidForLanguageFallback
  {
    /// <summary>
    /// Processes the specified arguments.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public void Process([NotNull] GetFieldValueArgs args)
    {
      if (!args.AllowFallbackValue)
      {
        return;
      }

      var languageFallbackFieldValuesManager = (BaseLanguageFallbackFieldValuesManager)ServiceLocator.ServiceProvider.GetService(typeof(BaseLanguageFallbackFieldValuesManager));

      args.IsValidForLanguageFallback = languageFallbackFieldValuesManager.IsValidForFallback(args.Field);
    }
  }
}