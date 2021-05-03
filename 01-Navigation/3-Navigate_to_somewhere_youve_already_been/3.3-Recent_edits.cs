using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Recently Changed Files
    //
    // Shows a popup menu of recent edits. Shows code blocks, not files
    //
    // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 最近の編集内容をポップアップメニューで表示出来ます。
    // (ReSharper) ファイルではなくコードブロックが表示出来ます。
    //
    // <shortcut id="Recently Changed Files">Ctrl+Shift+,    (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Recently Changed Files">Ctrl+E (Toggle) (Rider Default IntelliJ Keymap)</shortcut>
    //

    public class RecentEdits
    {
        private string firstName;
        private string lastName;

        public RecentEdits(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string GetName()
        {
            // 1. Implement GetName by returning firstName
            //    Uncomment the following and comment Exception line
            // return firstName;
            // 1. firstName を返す GetName を実装してください。
            //    コメントを外して Exception の行はコメントアウトしてください。
            // return firstName;
            throw new NotImplementedException();
        }

        public void Dump()
        {
            // 2. Implement by uncommenting
            // Console.WriteLine("Name: {0}", GetName());

            // 3. Return to GetName using Recent Edits and change to be firstName + lastName
            // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>

            // 4. Return back here and uncomment the following
            //     NOTE: There is no great significance to this implementation.
            //           It is content to let you experience the feel
            //           of the navigation controls.
            // 3. GetName に ”Recent Edits" を使って戻り、 firstName + lastName に実装を変更します。

            // 4. ここに戻って以下のコメントを外してください。
            //    (この実装に大きな意味はありません。移動の操作感を体験してもらう内容です。)
            //TODO: Riderではこの演習は機能しない。コードブロック表示ではなくファイルリストで、自ファイルは表示されない。
            // Console.WriteLine("Done");
        }
    }
}
