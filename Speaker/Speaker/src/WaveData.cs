using System;
using System.Collections.Generic;
using System.Text;

namespace WaveLib
{
    class WaveData
    {
        public int m_numAudio;
        public int m_duration;
        public int m_durationOverlap;
        public string m_audioPath1;
        public string m_audioPath2;

        public WaveData(int numAudio, int duration, int durationOverlap, string audioPath1, string audioPath2)
        {
            m_numAudio = numAudio;
            m_duration = duration;
            m_durationOverlap = durationOverlap;
            m_audioPath1 = audioPath1;
            m_audioPath2 = audioPath2;
        }

        public void SetData(int numAudio, int duration, int durationOverlap, string audioPath1, string audioPath2)
        {
            m_numAudio = numAudio;
            m_duration = duration;
            m_durationOverlap = durationOverlap;
            m_audioPath1 = audioPath1;
            m_audioPath2 = audioPath2;
        }
    }
}
