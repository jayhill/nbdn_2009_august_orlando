using System;
using System.IO;
using developwithpassion.commons.core.infrastructure.logging;

namespace nothinbutdotnetstore.infrastructure.logging.basic
{
    public class TextWriterLogger : Logger
    {
        TextWriter writer;

        public TextWriterLogger(TextWriter writer)
        {
            this.writer = writer;
        }

        public void informational(string message)
        {
writer.WriteLine(message);
        }

        public void error(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}