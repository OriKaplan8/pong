
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null)
        {
            BaseEventData eventData  = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }

}
