using System.Windows;
using System.Windows.Media.TextFormatting;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;

namespace Microsoft.PowerToolsEx.BlockTagger
{
    public interface ISemanticBlockTag : ITag
    {
        // to remove
        SnapshotSpan Span { get; }

        BlockType Type { get; }

        // to remove
        int Level { get; }

        // to remove
        SnapshotPoint StatementStart { get; }

        // to remove
        ISemanticBlockTag Parent { get; }

        // to remove
        FrameworkElement Context(BlockColoring coloring, TextRunProperties properties);
    }

    public enum BlockType
    {
        Root, Loop, Conditional, Method, Class, Namespace, Other, Unknown
    }
}
