using System;
using System.Collections.Generic;
using System.Text;

namespace WaveLib
{
    class WavePlayer
    {
        private WaveLib.WaveOutPlayer m_Player1;
        private WaveLib.WaveOutPlayer m_Player2;
        private WaveLib.WaveFormat m_Format1;
        private WaveLib.WaveFormat m_Format2;
        private System.IO.Stream m_AudioStream1;
        private System.IO.Stream m_AudioStream2;
        private bool m_Finished1 = false;
        private bool m_Finished2 = false;

        private void Filler1(IntPtr data, int size, ref bool finished)
        {
            byte[] b = new byte[size];
            if (m_AudioStream1 != null)
            {
                int pos = 0;
                while (pos < size)
                {
                    finished = m_Finished1;
                    int toget = size - pos;
                    int got = m_AudioStream1.Read(b, pos, toget);
                    if (got < toget)
                    {
                        finished = true;
                        break;
                        m_AudioStream1.Position = 0; // loop if the file ends
                    }
                    pos += got;
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                    b[i] = 0;
            }
            System.Runtime.InteropServices.Marshal.Copy(b, 0, data, size);
        }

        private void Filler2(IntPtr data, int size, ref bool finished)
        {
            byte[] b = new byte[size];
            if (m_AudioStream2 != null)
            {
                int pos = 0;
                while (pos < size)
                {
                    finished = m_Finished2;
                    int toget = size - pos;
                    int got = m_AudioStream2.Read(b, pos, toget);
                    if (got < toget)
                    {
                        finished = true;
                        break;
                        m_AudioStream2.Position = 0; // loop if the file ends
                    }
                    pos += got;
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                    b[i] = 0;
            }
            System.Runtime.InteropServices.Marshal.Copy(b, 0, data, size);
        }

        public void playWave(WaveData data)
        {
            CloseFile();

            switch (data.m_numAudio)
            {
                case 0:
                    {
                        try
                        {
                            System.Threading.Thread.Sleep(data.m_duration);
                        }
                        catch (System.Exception err)
                        {
                            throw new Exception(err.ToString());
                        }
                    }
                    break;

                case 1:
                    {
                        try
                        {
                            WaveLib.WaveStream S = new WaveLib.WaveStream(data.m_audioPath1);
                            if (S.Length <= 0)
                                throw new Exception("Invalid WAV file");
                            m_Format1 = S.Format;
                            if (m_Format1.wFormatTag != (short)WaveLib.WaveFormats.Pcm && m_Format1.wFormatTag != (short)WaveLib.WaveFormats.Float)
                                throw new Exception("Olny PCM files are supported");
                            m_AudioStream1 = S;

                            Stop();

                            if (m_AudioStream1 != null)
                            {
                                m_AudioStream1.Position = 0;
                                m_Player1 = new WaveLib.WaveOutPlayer(-1, m_Format1, 16384, 3, new WaveLib.BufferFillEventHandler(Filler1));
                            }

                            System.Threading.Thread.Sleep(data.m_duration);
                        }
                        catch (System.Exception err)
                        {
                            throw new Exception(err.ToString());
                        }
                    }
                    break;

                case 2:
                    {
                        try
                        {
                            WaveLib.WaveStream S = new WaveLib.WaveStream(data.m_audioPath1);
                            if (S.Length <= 0)
                                throw new Exception("Invalid WAV file");
                            m_Format1 = S.Format;
                            if (m_Format1.wFormatTag != (short)WaveLib.WaveFormats.Pcm && m_Format1.wFormatTag != (short)WaveLib.WaveFormats.Float)
                                throw new Exception("Olny PCM files are supported");
                            m_AudioStream1 = S;

                            WaveLib.WaveStream S1 = new WaveLib.WaveStream(data.m_audioPath2);
                            if (S1.Length <= 0)
                                throw new Exception("Invalid WAV file");
                            m_Format2 = S1.Format;
                            if (m_Format2.wFormatTag != (short)WaveLib.WaveFormats.Pcm && m_Format2.wFormatTag != (short)WaveLib.WaveFormats.Float)
                                throw new Exception("Olny PCM files are supported");
                            m_AudioStream2 = S1;

                            Stop();

                            if (m_AudioStream1 != null)
                            {
                                m_AudioStream1.Position = 0;
                                m_Player1 = new WaveLib.WaveOutPlayer(-1, m_Format1, 16384, 3, new WaveLib.BufferFillEventHandler(Filler1));
                            }

                            if (data.m_durationOverlap > 0)
                                System.Threading.Thread.Sleep(data.m_durationOverlap);

                            if (m_AudioStream2 != null)
                            {
                                m_AudioStream2.Position = 0;
                                m_Player2 = new WaveLib.WaveOutPlayer(-1, m_Format2, 16384, 3, new WaveLib.BufferFillEventHandler(Filler2));
                            }

                            System.Threading.Thread.Sleep(data.m_duration - data.m_durationOverlap);
                        }
                        catch (System.Exception err)
                        {
                            throw new Exception(err.ToString());
                        }
                    }
                    break;

                default:
                    {
                    }
                    break;
            }
        }

        private void Stop()
        {
            if (m_Player1 != null)
                try
                {
                    m_Player1.Dispose();
                }
                finally
                {
                    m_Player1 = null;
                }
            if (m_Player2 != null)
                try
                {
                    m_Player2.Dispose();
                }
                finally
                {
                    m_Player2 = null;
                }
        }

        public void CloseFile()
        {
            Stop();
            if (m_AudioStream1 != null)
                try
                {
                    m_AudioStream1.Close();
                }
                finally
                {
                    m_AudioStream1 = null;
                }
            if (m_AudioStream2 != null)
                try
                {
                    m_AudioStream2.Close();
                }
                finally
                {
                    m_AudioStream2 = null;
                }
        }

        public void reset()
        {
            if (m_Player1 != null)
                try
                {
                    m_Player1.Dispose();
                }
                finally
                {
                    m_Player1 = null;
                }
            if (m_Player2 != null)
                try
                {
                    m_Player2.Dispose();
                }
                finally
                {
                    m_Player2 = null;
                }
            if (m_AudioStream1 != null)
                try
                {
                    m_AudioStream1.Close();
                }
                finally
                {
                    m_AudioStream1 = null;
                }
            if (m_AudioStream2 != null)
                try
                {
                    m_AudioStream2.Close();
                }
                finally
                {
                    m_AudioStream2 = null;
                }
        }
    }
}
