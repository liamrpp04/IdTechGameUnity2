using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectUtils;
using UnityEngine.Events;
using ReachableGames.PostLinerFree;

public class InteractableSpeaker : Interactable
{
    [System.Serializable]
    public class IDialog
    {
        public string[] dialogs;
        public UnityEvent OnCompleted;
    }
    public enum State
    {
        Default,
        Waiting,
        Finished
    }

    public ItemData itemRequired;
    public int amountRequired = 1;
    public bool devMode = false;
    private State state;
    bool isWaiting = false;

    [SerializeField] private string title;
    //[SerializeField] private string[] FirstDialogs;
    //[SerializeField] private UnityEvent OnCompleted;
    //[SerializeField] private string[] WaitingDialogs;
    //[SerializeField] private string[] FinalDialogs;
    [SerializeField] private IDialog FirstDialogs;
    [SerializeField] private IDialog WaitingDialogs;
    [SerializeField] private IDialog FinalDialogs;

    //[SerializeField] private UnityEvent OnSuccess;
    //[SerializeField] private UnityEvent OnFailed;
    [SerializeField] private ItemData rewardItem;

    public override void Evaluate(ItemInHand itemInHand)
    {
        PlayerController.SetControl(false);
        SoundManager.PlayOneShot("greet", 0.65f);

        PostLinerOutline outline = GetComponent<PostLinerOutline>();
        switch (state)
        {
            case State.Default:
                if (outline != null) outline.enabled = false;

                DialogUI.Show(title, FirstDialogs.dialogs, () =>
                {
                    if (outline != null) outline.enabled = true;

                    FirstDialogs.OnCompleted?.Invoke();
                    this.ActionAfterReturnedNull(() =>
                    {
                        PlayerController.SetControl(true);
                    });
                    state = State.Waiting;
                });
                break;
            case State.Waiting:
#if UNITY_EDITOR
                if (outline != null) outline.enabled = false;

                if (devMode)
                {
                    SuccessInteraction();
                    return;
                }
#endif
                if (itemRequired == null || amountRequired == 0)
                {
                    SuccessInteraction();
                    return;
                }

                if (itemInHand == null || itemRequired != itemInHand.data)
                {
                    FailInteraction();
                    return;
                }

                InventoryItem inventoryItem = Inventory.Get(itemRequired);

                if (inventoryItem.stackSize >= amountRequired)
                {
                    Inventory.Remove(itemRequired, amountRequired);
                    SuccessInteraction();
                    //
                }
                else
                {
                    FailInteraction();
                }

                break;
            case State.Finished:

                break;
            default:
                break;
        }

    }

    void FailInteraction()
    {
        //ShortPopupUI.ShowFailedInteraction(this);
        DialogUI.Show(title, WaitingDialogs.dialogs, () =>
        {
            WaitingDialogs.OnCompleted?.Invoke();
            this.ActionAfterReturnedNull(() =>
            {
                PlayerController.SetControl(true);

                PostLinerOutline outline = GetComponent<PostLinerOutline>();
                if (outline != null) outline.enabled = true;

            });
        });
    }

    void SuccessInteraction()
    {
        DialogUI.Show(title, FinalDialogs.dialogs, () =>
        {
            FinalDialogs.OnCompleted?.Invoke();
            if (rewardItem != null) Inventory.Add(rewardItem);
            this.ActionAfterReturnedNull(() =>
            {
                PlayerController.SetControl(true);

                //PostLinerOutline outline = GetComponent<PostLinerOutline>();
                //if (outline != null) outline.enabled = true;
            });
            state = State.Finished;

        });
        Clear();
    }

    private void Clear()
    {
        gameObject.layer = 0;
    }
}
