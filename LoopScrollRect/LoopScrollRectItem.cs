using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    /// <summary>
    ///
    /// </summary>
    public class LoopScrollRectItem : MonoBehaviour, IPointerClickHandler, ILoopScrollCellReturn
    {
        /// <summary>
        /// ����¼�
        /// </summary>
        public Action<Transform, int> m_clickItemCallBack;

        [SerializeField]
        private int m_index = -1;

        public int Index
        {
            get => m_index;
            set => m_index = value;
        }

        /// <summary>
        /// �̳е���¼�
        /// </summary>
        /// <param name="_eventData"></param>
        public void OnPointerClick(PointerEventData _eventData)
        {
            m_clickItemCallBack?.Invoke(this.transform, m_index);
        }

        public void ScrollCellReturn()
        {
            m_index = -1;
        }
    }
}