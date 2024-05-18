using System.IO;
using System.Reflection;

namespace sbHtmlEdit.Core
{
    internal static class JsDepot
    {
        ///////////////////////////////////////////////////////////
        #region Script resource paths
        /////////////////////////////

        private static readonly string path_DesignMode = "sbHtmlEdit.Javascript.DesignMode.js";

        private static readonly string path_SetInitialCursorPos = "sbHtmlEdit.Javascript.SetInitialCursorPosition.js";

        private static readonly string path_InsertElement = "sbHtmlEdit.Javascript.InsertElement.js";
        private static readonly string path_InsertInlineImage = "sbHtmlEdit.Javascript.InsertInlineImage.js";
        private static readonly string path_CreateSpanForSelection = "sbHtmlEdit.Javascript.CreateSpanForSelection.js";
        private static readonly string path_CreateDivForSelection = "sbHtmlEdit.Javascript.CreateDivForSelection.js";
        private static readonly string path_CheckForTextSelection = "sbHtmlEdit.Javascript.CheckForTextSelection.js";

        private static readonly string path_BodyObserver = "sbHtmlEdit.Javascript.BodyObserver.js";
        private static readonly string path_CursorMovedListener = "sbHtmlEdit.Javascript.CursorMovedListener.js";
        private static readonly string path_MouseListener = "sbHtmlEdit.Javascript.InstallMouseListener.js";
        private static readonly string path_KeyboardListener = "sbHtmlEdit.Javascript.InstallKeyboardListener.js";
        private static readonly string path_EnterKeyOverride = "sbHtmlEdit.Javascript.InstallEnterKeyOverride.js";

        private static readonly string path_ResampleBody = "sbHtmlEdit.Javascript.ResampleBody.js";
        private static readonly string path_GetBodyInnerHTML = "sbHtmlEdit.Javascript.GetBodyInnerHTML.js";
        private static readonly string path_SetBodyInnerHTML = "sbHtmlEdit.Javascript.SetBodyInnerHTML.js";
        private static readonly string path_GetBodyOuterHTML = "sbHtmlEdit.Javascript.GetBodyOuterHTML.js";
        private static readonly string path_SetBodyOuterHTML = "sbHtmlEdit.Javascript.SetBodyOuterHTML.js";
        private static readonly string path_GetBodyAttribute = "sbHtmlEdit.Javascript.GetBodyAttribute.js";
        private static readonly string path_SetBodyAttribute = "sbHtmlEdit.Javascript.SetBodyAttribute.js";
        private static readonly string path_SetBodyStyleProperty = "sbHtmlEdit.Javascript.SetBodyStyleProperty.js";

        private static readonly string path_SetElementId = "sbHtmlEdit.Javascript.SetElementId.js";
        private static readonly string path_GetElementInnerHTML = "sbHtmlEdit.Javascript.GetElementInnerHTML.js";
        private static readonly string path_SetElementInnerHTML = "sbHtmlEdit.Javascript.SetElementInnerHTML.js";
        private static readonly string path_GetElementOuterHTML = "sbHtmlEdit.Javascript.GetElementOuterHTML.js";
        private static readonly string path_SetElementOuterHTML = "sbHtmlEdit.Javascript.SetElementOuterHTML.js";
        private static readonly string path_GetElementAttribute = "sbHtmlEdit.Javascript.GetElementAttribute.js";
        private static readonly string path_SetElementAttribute = "sbHtmlEdit.Javascript.SetElementAttribute.js";
        private static readonly string path_SetElementStyleProperty = "sbHtmlEdit.Javascript.SetElementStyleProperty.js";

        private static readonly string path_SetActiveElementAttribute = "sbHtmlEdit.Javascript.SetActiveElementAttribute.js";

        private static readonly string path_StandardTextEditCall = "sbHtmlEdit.Javascript.StandardTextEditCall.js";

        /////////////////////////////
        #endregion Script resource paths
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Scripts by name
        /////////////////////////////

        public static string js_DesignMode { get; private set; } = string.Empty;

        public static string js_SetInitialCursorPos { get; private set; } = string.Empty;

        public static string js_InsertElement { get; private set; } = string.Empty;
        public static string js_InsertInlineImage { get; private set; } = string.Empty;
        public static string js_CreateSpanForSelection { get; private set; } = string.Empty;
        public static string js_CreateDivForSelection { get; private set; } = string.Empty;
        public static string js_CheckForTextSelection { get; private set; } = string.Empty;

        public static string js_InstallBodyObserver { get; private set; } = string.Empty;
        public static string js_InstallCursorMoveListener { get; private set; } = string.Empty;
        public static string js_InstallMouseListener { get; private set; } = string.Empty;
        public static string js_InstallKeyboardListener { get; private set; } = string.Empty;
        public static string js_InstallEnterKeyOverride { get; private set; } = string.Empty;

        public static string js_ResampleBody { get; private set; } = string.Empty;
        public static string js_GetBodyInnerHTML { get; private set; } = string.Empty;
        public static string js_SetBodyInnerHTML { get; private set; } = string.Empty;
        public static string js_GetBodyOuterHTML { get; private set; } = string.Empty;
        public static string js_SetBodyOuterHTML { get; private set; } = string.Empty;
        public static string js_GetBodyAttribute { get; private set; } = string.Empty;
        public static string js_SetBodyAttribute { get; private set; } = string.Empty;
        public static string js_SetBodyStyleProperty { get; private set; } = string.Empty;

        public static string js_SetElementId { get; private set; } = string.Empty;
        public static string js_GetElementInnerHTML { get; private set; } = string.Empty;
        public static string js_SetElementInnerHTML { get; private set; } = string.Empty;
        public static string js_GetElementOuterHTML { get; private set; } = string.Empty;
        public static string js_SetElementOuterHTML { get; private set; } = string.Empty;
        public static string js_GetElementAttribute { get; private set; } = string.Empty;
        public static string js_SetElementAttribute { get; private set; } = string.Empty;
        public static string js_SetElementStyleProperty { get; private set; } = string.Empty;

        public static string js_SetActiveElementAttribute { get; private set; } = string.Empty;

        public static string js_StandardTextEditCall { get; private set; } = string.Empty;

        /////////////////////////////
        #endregion Scripts by name
        ///////////////////////////////////////////////////////////



        static JsDepot()
        {
            js_DesignMode = LoadScript(path_DesignMode);

            js_SetInitialCursorPos = LoadScript(path_SetInitialCursorPos);

            js_InsertElement = LoadScript(path_InsertElement);
            js_InsertInlineImage = LoadScript(path_InsertInlineImage);
            js_CreateSpanForSelection = LoadScript(path_CreateSpanForSelection);
            js_CreateDivForSelection = LoadScript(path_CreateDivForSelection);
            js_CheckForTextSelection = LoadScript(path_CheckForTextSelection);

            js_InstallBodyObserver = LoadScript(path_BodyObserver);
            js_InstallCursorMoveListener = LoadScript(path_CursorMovedListener);
            js_InstallMouseListener = LoadScript(path_MouseListener);
            js_InstallKeyboardListener = LoadScript(path_KeyboardListener);
            js_InstallEnterKeyOverride = LoadScript(path_EnterKeyOverride);
            
            js_ResampleBody = LoadScript(path_ResampleBody);

            js_GetBodyInnerHTML = LoadScript(path_GetBodyInnerHTML);
            js_GetBodyOuterHTML = LoadScript(path_GetBodyOuterHTML);
            js_GetBodyAttribute = LoadScript(path_GetBodyAttribute);

            js_SetBodyInnerHTML = LoadScript(path_SetBodyInnerHTML);
            js_SetBodyOuterHTML = LoadScript(path_SetBodyOuterHTML);
            js_SetBodyAttribute = LoadScript(path_SetBodyAttribute);
            js_SetBodyStyleProperty = LoadScript(path_SetBodyStyleProperty);

            js_SetElementId = LoadScript(path_SetElementId);

            js_GetElementInnerHTML = LoadScript(path_GetElementInnerHTML);
            js_GetElementOuterHTML = LoadScript(path_GetElementOuterHTML);
            js_GetElementAttribute = LoadScript(path_GetElementAttribute);

            js_SetElementInnerHTML = LoadScript(path_SetElementInnerHTML);
            js_SetElementOuterHTML = LoadScript(path_SetElementOuterHTML);
            js_SetElementAttribute = LoadScript(path_SetElementAttribute);
            js_SetElementStyleProperty = LoadScript(path_SetElementStyleProperty);

            js_SetActiveElementAttribute = LoadScript(path_SetActiveElementAttribute);

            js_StandardTextEditCall = LoadScript(path_StandardTextEditCall);
        }

        
        static string LoadScript(string jsName)
        {
            string script = string.Empty;
            try
            {
                using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(jsName))
                {
                    if (resource is not null)
                    {
                        using (var stream = new StreamReader(resource))
                        {
                            script = stream.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
            return script;
        }
    }
}
