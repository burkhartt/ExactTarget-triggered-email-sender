using System.Collections.Generic;

namespace ExactTarget.TriggeredEmail.Creation
{
    public interface ITriggeredEmailCreator
    {
        int Create(string externalKey);
        int CreateTriggeredSendDefinitionWithEmailTemplate(string externalKey, string layoutHtmlAboveBodyTag, string layoutHtmlBelowBodyTag);
        int CreateTriggeredSendDefinitionWithEmailTemplate(string externalKey, string layoutHtmlAboveBodyTag, string layoutHtmlBelowBodyTag, HashSet<string> fields, string emailName = null);

        int CreateTriggeredSendDefinitionWithPasteHtml(string externalKey);
        void StartTriggeredSend(string externalKey);
    }
}