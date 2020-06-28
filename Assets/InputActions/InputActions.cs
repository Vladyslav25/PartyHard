// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""BoardMovement"",
            ""id"": ""70031340-deed-4f16-8b6c-a69eb14d2c1b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4283e353-aff0-45da-8515-0fccc075b21e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""279af0b2-64c7-466e-ac46-c5b36be84224"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c3814ba-9163-432c-a908-dfd8d8d4fe6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2fe58dd3-cedc-4020-8195-5598af8e41ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1c1be08e-6eaf-431d-9990-891fd042b178"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69ecc1f2-53c8-464c-9f6d-b78438e8c422"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""d97af5e9-b797-4ad5-ac1a-9e353820ab5a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aeaef8da-c33b-4f4d-9e96-c29ce5e7c9f3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ecb6271-b836-4759-8ff6-8ae93645da2d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1ad4e12d-1dc8-4df7-907b-801129b5a8d0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c81ed876-dcef-4093-8efe-e577e03af183"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""bb04b00c-5c7c-427e-98d7-508860f63c18"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6206fd78-a449-42cf-8b89-31dd197d1ec3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""05e0cff7-d780-4fd8-a93d-f66a70d55edf"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""189bf757-4cf2-4b32-a600-b269ce076d03"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f32559d2-3820-4d63-8609-f492a84f3011"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""AsterioidenDoge"",
            ""id"": ""085c28c2-730d-45da-8b64-b28e50b049cf"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4b3c8279-91b7-4c03-aaa0-12f46ff5fcb9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e7f8691f-4f09-44d9-9198-d21cf81bc89f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""39858ad1-93b5-4078-8f0d-c8e4cf515fb3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""22538c78-8527-4ace-a7e0-3dcbf60b06bb"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b4ef8876-af76-45b1-8826-ea3a65301302"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c2c8cff8-0049-47bb-bc4d-2b4a5bef0df9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a133282-0969-4a8c-bf8f-26b8539128af"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cd0bff10-f0df-454a-9f07-041908f277e4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8ff1b036-d031-488d-aafc-2bb58c90a04b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""663b2268-e3aa-4b49-90ab-bc804912a8e0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""51c5f99b-a55c-4645-a050-f1e1446982a8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6e44097e-13fd-4ff6-a443-cf984d022fbd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2ffcf045-67f2-423f-965c-9cf615e2e219"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ac452de-755d-4c93-a994-9d172ff9cb29"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HotPotato"",
            ""id"": ""c29a6cea-dedf-4db2-9b0a-71695fe7446e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e427973a-ba08-4672-a855-1bdcf86ac165"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7ad0f842-e3e7-49e2-96d1-77f7d79afe3e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""339b24f4-05a9-40d0-bb7a-f7c21a1cbb33"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""644d71be-2899-4dee-8684-471dc911827d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4879600-ab21-4de7-86dc-8db30ef1963a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9afcf720-942d-41c0-9ebc-f7b1e4a4746a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""f9ef4ce1-39de-4dde-9242-2657c7e5b4ef"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e810aacd-1861-4916-96bb-d53909fca444"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44821162-dff0-47a8-9ccf-f20323fd1daf"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1dc87d26-7982-4127-82c9-56b0d6ebc84f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""25f06584-1f43-401b-8c95-65c3ae7e9d3a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""IconLook"",
            ""id"": ""25a01fa7-be0b-4626-a04e-c0ca79e661d0"",
            ""actions"": [
                {
                    ""name"": ""LookUp"",
                    ""type"": ""Button"",
                    ""id"": ""c8572ff2-e77b-4e33-9bce-a491694c10f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookDown"",
                    ""type"": ""Button"",
                    ""id"": ""566bf62f-cd16-47e4-b21e-e83ff8e0e1f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookRight"",
                    ""type"": ""Button"",
                    ""id"": ""b879cd39-9bf8-40a6-b86c-75a6b521b255"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d402b27d-6a62-475a-80e9-2239463b5f00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4dfdb17a-a460-400a-bd6e-daa9f78dd3eb"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b47d359-467f-4cb9-b4a1-d7b15fe7a705"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LookUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc0b210e-085f-4f5b-b790-8ecc28c8482c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df91c15f-82bc-416d-aab3-d5bf3608707a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LookDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d065d43-45a3-44c1-97ea-950a468fbc1a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c34c7c5-51e2-441e-9dd6-f6d7635d22fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LookRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67163442-3c16-4c55-8851-dde7fd29d161"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5936746-7951-4666-9bc1-d04184e6ed1b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Bomber"",
            ""id"": ""2773b588-7f43-45ce-8898-3e4d5084d29a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ab24aa15-c4b1-4f30-a64c-685d25aff5c5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""29352e2b-14fb-4025-ba7b-15c13ce9ba43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""4958cf1c-13ac-47ee-96ff-119d7012b2b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d68609e4-4fbe-4502-ae17-0e799d0fda83"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""494be1f9-e77b-4ac7-8107-64fdcfea2b7a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""36a99bbf-82fa-4780-bdb9-c3f606ac9d5a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c4e160de-b9ad-4c24-b8bc-d9ade82f2ea8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""3629a18e-86bb-40f9-ad24-bf1ef697728c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53290311-6e17-43e2-807c-c237b9fc3064"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd4b08fd-3e4c-4e72-8e52-8122921db9d2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0138dfa7-87a2-4c5a-a725-08b76ff58238"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""780f6c9d-f417-43ce-8dac-2efe0116dd90"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5df6880f-2b04-49e0-aa70-42d6db0d884c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""269434d4-6d6f-460a-b5b1-e3b9ab6a986f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TnTRun"",
            ""id"": ""24b33943-5be9-4c52-b4b8-c789204d93f5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ea0da787-40cf-4119-a15e-40d0e2550d7f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""10cd00cc-b8c5-41f9-b330-14e3be63fae8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eff3e760-e988-4a98-87a2-0244de0d31a0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""84d8b8ed-f8bf-4533-94e4-94143d242b0e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5569b278-f4fc-4443-aad4-3e6039715942"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41f0dbe6-2d87-4895-bf2e-136c8f121fd4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""839c2de8-1e0e-497a-bc42-9994f4cbc14c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eaf26d57-0f26-48ed-895a-979304ad5c82"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f7c0ebf-eda7-4fd3-8db1-b31da5f39a70"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b5f148a8-c573-4ebf-8ad4-8095955b4772"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0fdbb6fa-1e0b-44f2-969c-1ec9ed85c3c2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""KnockbackPlattform"",
            ""id"": ""bbd580f0-af78-4e2c-8489-bb090c40f10d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ec2595b1-734c-4236-ad69-b8af3f53e662"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KnockBack"",
                    ""type"": ""Button"",
                    ""id"": ""5a6b3107-d86a-4e73-9769-1aaba3e97cc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""df4de4dc-301e-49ed-a33f-64e8f71784f8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7adbb241-4c4b-4a34-927e-0d2f75f7e2e8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eae20696-12f8-4fc2-8794-04de2e179376"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d22ea1bb-f464-403d-81f4-eb3829f093be"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c97a0f6a-f4d3-465b-b236-deb4b41b3f4c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""353b01d3-0d6d-4fb8-95c9-1cf00fa4f5ae"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""06be9898-9263-471c-b0e4-bda0ed7bacfd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""02258e25-848d-492e-8465-a851ed9d89b0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5020bc8d-959d-4615-9de0-9aa2b7c9d85c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e2ee2c24-39f9-4b76-aaed-ba6acfb8b366"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""774cd279-e3b0-427a-9fa7-c6f22b4ef714"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""KnockBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18984e3b-52d7-445b-919c-9f700ed7d11b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""KnockBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DontMove"",
            ""id"": ""b6a02feb-68a6-4917-81ab-a2642fcc7885"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""dfe9dca0-4bfc-42dc-b0f8-f4597e1f24ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""ad97f7f5-6072-4b79-88fc-c9e4ac8f3745"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cf69ff3e-1168-4033-870f-040f23e20043"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""41df2666-6207-471e-84a2-b8c8fb71820c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""01213813-cf59-43a7-b080-8e983af00a70"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f62a513c-a761-469d-967c-62f6f0a15477"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6eb8cfa5-d5b2-4ced-8005-b24fa40c87f5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0829b142-15be-4513-92ec-fdbfcf2ae730"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8f273df3-e92f-4d3e-9855-31b54a19f871"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f4ade82c-99e0-4338-9ed2-57284afd3de9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec8e28ac-06b5-4edf-af12-63ea5286510c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BiggerWins"",
            ""id"": ""27076c70-1498-4883-a037-14126f6bf86b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4053ca9d-d8cd-4c06-8960-524890076c53"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Choose"",
                    ""type"": ""Button"",
                    ""id"": ""41f06da4-c452-4973-81b7-34bffb6116b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f47660db-9911-4146-8f4c-0093010ad6b4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c10d2ad3-cfaa-4d3e-8057-9cd3970633c5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""e80c2c5d-7e7f-48c5-a254-cbeed3373a4e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f1d6813-ed9f-4ff6-98ee-acd4a2ca9444"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""543f5902-096b-48af-aba3-4a308ba111e5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2ed990f5-8a65-4a1f-b95b-53ed56fcf88e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""71aaaac7-c6e1-4e5d-9c74-09741f59bd40"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cccf732b-e9c9-4583-8553-c28e61671cd3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6d0a3c2-0e2a-40ab-bd0c-9b38f0ca587a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff6cb18e-6884-42a3-a30c-06d361eff729"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d028127-0fe5-4a2c-b6b4-bf4c8dc1bb4b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""324eec15-6ade-4d40-9db4-5f27bdeb5cf5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BoxRunning"",
            ""id"": ""37c9c72b-bc54-4169-bf95-d2698467284a"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9df5613c-38c8-4922-8775-e81428f2f30e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e2559c6-3d61-4e7b-85c6-adc4fd21c9da"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd326fc3-bad0-4980-ae68-5025220f08e2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CatchTheToast"",
            ""id"": ""34645013-05a8-45d9-938e-a1015d278e9b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""91775d0f-068a-4525-ab8a-411f8b6e9d9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""671da635-d40d-4ca9-a157-000769ad04ca"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""86903d46-51e5-497d-a7fa-c9df9597ef00"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""080409c9-dc9e-433f-a4da-0d921317ffe7"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""17d660bb-1541-47a7-a8f3-12544d28d633"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6822eb0c-da45-4625-be4a-fc0770f3b438"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2e0c82f0-6ede-4f20-a7bb-b17fce48f305"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0e9ddd2e-0651-416e-a165-380c4cb28fad"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0bd33edf-34d1-4bc6-8d91-973d7c3b7b78"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1626de10-c3b7-4cd1-a55a-0e3cecfe9b6d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42f3f11a-0ebc-455e-9e2a-cc853a3c8927"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""LookMindRepeat"",
            ""id"": ""e6d1ce76-3ec0-4738-b167-41043daaa0ea"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""CountTheSheep"",
            ""id"": ""c22771f5-de09-43e6-b4ee-e9058fda7760"",
            ""actions"": [
                {
                    ""name"": ""CountUp"",
                    ""type"": ""Button"",
                    ""id"": ""70def67f-c501-46b6-9904-52bb6df52943"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CountDown"",
                    ""type"": ""Button"",
                    ""id"": ""5acee260-7fdc-4457-a8ab-bc3349417374"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29097122-edcf-477a-bda3-bffe8dfdddd2"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CountUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dc3f18b-aa4c-465e-8f42-9ccd65287465"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CountUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b79e78cc-b494-4294-bcd8-26ca8b389d38"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CountDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""450b2da8-f9cd-4f14-a934-e21011a0efbe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CountDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ChooseTheCloud"",
            ""id"": ""8a8cf63d-ad55-4aab-b73c-809483ffdb4d"",
            ""actions"": [
                {
                    ""name"": ""JumpUp"",
                    ""type"": ""Button"",
                    ""id"": ""64280397-855c-4480-9b99-b8a147b9aa78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpDown"",
                    ""type"": ""Button"",
                    ""id"": ""11498fc3-741b-44d6-81ac-4fe50bac70ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpRight"",
                    ""type"": ""Button"",
                    ""id"": ""1b08930c-aa5a-4787-b6e3-c84f916eb828"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpLeft"",
                    ""type"": ""Button"",
                    ""id"": ""18a1d01a-1be5-4647-93c1-de124b94ea10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""81c2ecae-7f73-49cc-a1b4-767c3c17eb14"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JumpUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d4c8985-e275-4ae2-bbd3-6b2dacef7ac2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""JumpUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e4d4070-b35a-4d5b-a4f5-7ce03eb0eb3d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JumpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6e96cc0-642e-421a-b48e-e40ff76eb846"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""JumpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a86f566-845a-45bf-8844-397cb358c184"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JumpRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8496046-be7e-4e0c-990e-266779509253"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""JumpRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""772d753b-3138-45a5-bb10-3e3a19c68ec2"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JumpLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8ec3b73-cc8a-4b37-8e85-d7b08f2c61f7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""JumpLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Labyrinth"",
            ""id"": ""cfaf3111-0a2c-45b4-93ba-d3e08197e1dc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""645fed14-421e-44ed-9c5c-baa2e0a8cfdc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KnockBack"",
                    ""type"": ""Button"",
                    ""id"": ""9eabc379-9a0e-45ac-b3f5-7188d2cb6bd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""bb38ce89-7da5-4159-83b0-4fdd15114b0c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a2e3a226-6725-46ca-8439-2b6a9c2a625d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f06f2e50-a50c-4c08-ad9b-fe077ea33185"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8c5e7285-ff55-47f8-b83e-8fc9911a9e04"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1eafa830-1d72-45ee-97dc-21d3632c7bb6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""baa0325b-1e68-4a03-b6d7-a819c31da292"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f17da2f1-d707-4a53-b140-7c2351342ad1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c49f955b-b0fd-4316-a8c3-58c3ffdd9d82"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3304890c-34da-4117-9537-b38817b5c622"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb67ece0-9e03-4745-ba06-5479057ec66d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""655c9724-b317-4cb4-9ef4-a868c9f3f49c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""KnockBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37b77f6e-7670-4681-8363-0571d58a3d2b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""KnockBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ReactionSlot"",
            ""id"": ""31f42744-0684-4e1e-a2c5-f30cfd46a8e6"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a37dd7f7-1e3d-4876-9042-7ef0b90db75d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ec0e83e-4b2d-42c4-8675-395618f72e74"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2684a184-8b3a-4452-a84e-eeecf7923c2c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HeadOrNumber"",
            ""id"": ""4e04051b-1920-4ec0-abd9-3c9dcb521a55"",
            ""actions"": [
                {
                    ""name"": ""Choose"",
                    ""type"": ""Button"",
                    ""id"": ""e0b2dda2-ef9f-46c5-9b1e-ea85fff124e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCourser"",
                    ""type"": ""Value"",
                    ""id"": ""b6a97c71-b57b-4134-97b6-34a2d1c32d12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e65866fb-1e14-4167-aeba-323f1a53e18d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""642fce8e-47a4-4e36-b528-ee27e32b3f60"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0b699916-d827-4610-a82b-6bf359e6acd8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b709c0e-5941-4bcc-a932-7832e5922969"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""367f9cad-3f1e-48df-a982-fd48e0e5df8d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""48dd4551-69cc-4f60-a9ed-acf7d73ce59a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""66be6540-c8dc-4ac7-b849-a07fb8c18939"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0eb24252-a6ea-4cd0-b4f0-43be99dd0faa"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveCourser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""JumpOrDuck"",
            ""id"": ""45f44b51-091e-46d7-8a72-00e6410d5be4"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""579aead7-c467-42db-aa9a-be95d5e25990"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""3f5d5a18-3a0d-4f09-99e7-d35b6579527d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b04868a5-9ecf-4d25-9627-5af21e460ac2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cebefda-b5ba-4efe-9c19-83fd1e905267"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7edc0a1-a913-45d9-bd6d-d83585807d0b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d28396c7-df8e-44e2-aa0d-d8f9942beeec"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Playfield"",
            ""id"": ""8ea8d623-2e7d-4a72-997c-d580c4b4aeb8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""e8d59665-fe2e-4755-a633-88aef1a70e76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""df623f97-466f-4599-8c6d-61b1fbaeef28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""[Keyboard] WASD"",
                    ""id"": ""16864b6d-818a-468f-8499-84342cdfbc39"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""822ec0e4-f0c2-4366-b1e4-cc4c099e2a7f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c580d83a-df88-4f42-b502-3f43a49facf7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29d6b635-0548-4307-85a0-e1c9dc20ca6d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b72541ed-33b3-4171-98b1-4bdca1f5312b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""[Keyboard] ArrowKey"",
                    ""id"": ""b03f0653-b58f-4b36-9235-62daebec4ac2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5b5a46ad-f06b-4906-9973-afa0acfce9cb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ba0c7491-d7b7-4f3c-a4f9-64bac2fec363"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a9d437b-16c0-4b26-bda7-97e743b0f2da"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cb34857e-f030-43e3-88fc-94d099b12481"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""[Gamepad] D-Pad"",
                    ""id"": ""79dc89ab-164f-4fbc-be72-1a865c97f062"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c191bc6f-c585-4e0b-8707-fb2aca6188e4"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f93a34f3-d76b-44ef-8843-24bef5b51939"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bdfa198f-af57-4aaa-ae7d-e3b07b31707e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0bd6b7a5-f6fc-4153-8456-c4e1a427fe8c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""[Gamepad] LeftStick"",
                    ""id"": ""61ae73fd-9bd4-4d57-851e-c5b969c26618"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""08cdd252-f00c-4a81-8b61-7c6d691c26ca"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3dbd20cd-6444-44a2-a5e2-80e779bd0e6e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6dfe827f-d181-4f5d-ba5c-61108ba2c832"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""abd97332-9ece-4f60-87ef-ac12f2d5d0f6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b59ede23-547d-4142-a43e-b937ddf08cee"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7c50c22-a5d4-4c3a-80e2-1c18f18c64cc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainMenu"",
            ""id"": ""de141a20-15a0-4acc-b6f8-773509e4f463"",
            ""actions"": [
                {
                    ""name"": ""AddPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""b78a6504-68a9-423b-9c68-e2937fe7c1b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a9f3c88-193c-4e1b-850c-123484e6a62a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AddPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31761d7b-1ef6-4899-a90e-e9a090a625c6"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AddPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaa03ef8-73bb-4875-8e2d-b20f87a9e352"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AddPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // BoardMovement
        m_BoardMovement = asset.FindActionMap("BoardMovement", throwIfNotFound: true);
        m_BoardMovement_Move = m_BoardMovement.FindAction("Move", throwIfNotFound: true);
        // AsterioidenDoge
        m_AsterioidenDoge = asset.FindActionMap("AsterioidenDoge", throwIfNotFound: true);
        m_AsterioidenDoge_Move = m_AsterioidenDoge.FindAction("Move", throwIfNotFound: true);
        m_AsterioidenDoge_Attack = m_AsterioidenDoge.FindAction("Attack", throwIfNotFound: true);
        // HotPotato
        m_HotPotato = asset.FindActionMap("HotPotato", throwIfNotFound: true);
        m_HotPotato_Move = m_HotPotato.FindAction("Move", throwIfNotFound: true);
        // IconLook
        m_IconLook = asset.FindActionMap("IconLook", throwIfNotFound: true);
        m_IconLook_LookUp = m_IconLook.FindAction("LookUp", throwIfNotFound: true);
        m_IconLook_LookDown = m_IconLook.FindAction("LookDown", throwIfNotFound: true);
        m_IconLook_LookRight = m_IconLook.FindAction("LookRight", throwIfNotFound: true);
        m_IconLook_LookLeft = m_IconLook.FindAction("LookLeft", throwIfNotFound: true);
        // Bomber
        m_Bomber = asset.FindActionMap("Bomber", throwIfNotFound: true);
        m_Bomber_Move = m_Bomber.FindAction("Move", throwIfNotFound: true);
        m_Bomber_Jump = m_Bomber.FindAction("Jump", throwIfNotFound: true);
        // TnTRun
        m_TnTRun = asset.FindActionMap("TnTRun", throwIfNotFound: true);
        m_TnTRun_Move = m_TnTRun.FindAction("Move", throwIfNotFound: true);
        // KnockbackPlattform
        m_KnockbackPlattform = asset.FindActionMap("KnockbackPlattform", throwIfNotFound: true);
        m_KnockbackPlattform_Move = m_KnockbackPlattform.FindAction("Move", throwIfNotFound: true);
        m_KnockbackPlattform_KnockBack = m_KnockbackPlattform.FindAction("KnockBack", throwIfNotFound: true);
        // DontMove
        m_DontMove = asset.FindActionMap("DontMove", throwIfNotFound: true);
        m_DontMove_Move = m_DontMove.FindAction("Move", throwIfNotFound: true);
        // BiggerWins
        m_BiggerWins = asset.FindActionMap("BiggerWins", throwIfNotFound: true);
        m_BiggerWins_Move = m_BiggerWins.FindAction("Move", throwIfNotFound: true);
        m_BiggerWins_Choose = m_BiggerWins.FindAction("Choose", throwIfNotFound: true);
        // BoxRunning
        m_BoxRunning = asset.FindActionMap("BoxRunning", throwIfNotFound: true);
        m_BoxRunning_Jump = m_BoxRunning.FindAction("Jump", throwIfNotFound: true);
        // CatchTheToast
        m_CatchTheToast = asset.FindActionMap("CatchTheToast", throwIfNotFound: true);
        m_CatchTheToast_Move = m_CatchTheToast.FindAction("Move", throwIfNotFound: true);
        // LookMindRepeat
        m_LookMindRepeat = asset.FindActionMap("LookMindRepeat", throwIfNotFound: true);
        // CountTheSheep
        m_CountTheSheep = asset.FindActionMap("CountTheSheep", throwIfNotFound: true);
        m_CountTheSheep_CountUp = m_CountTheSheep.FindAction("CountUp", throwIfNotFound: true);
        m_CountTheSheep_CountDown = m_CountTheSheep.FindAction("CountDown", throwIfNotFound: true);
        // ChooseTheCloud
        m_ChooseTheCloud = asset.FindActionMap("ChooseTheCloud", throwIfNotFound: true);
        m_ChooseTheCloud_JumpUp = m_ChooseTheCloud.FindAction("JumpUp", throwIfNotFound: true);
        m_ChooseTheCloud_JumpDown = m_ChooseTheCloud.FindAction("JumpDown", throwIfNotFound: true);
        m_ChooseTheCloud_JumpRight = m_ChooseTheCloud.FindAction("JumpRight", throwIfNotFound: true);
        m_ChooseTheCloud_JumpLeft = m_ChooseTheCloud.FindAction("JumpLeft", throwIfNotFound: true);
        // Labyrinth
        m_Labyrinth = asset.FindActionMap("Labyrinth", throwIfNotFound: true);
        m_Labyrinth_Move = m_Labyrinth.FindAction("Move", throwIfNotFound: true);
        m_Labyrinth_KnockBack = m_Labyrinth.FindAction("KnockBack", throwIfNotFound: true);
        // ReactionSlot
        m_ReactionSlot = asset.FindActionMap("ReactionSlot", throwIfNotFound: true);
        m_ReactionSlot_Jump = m_ReactionSlot.FindAction("Jump", throwIfNotFound: true);
        // HeadOrNumber
        m_HeadOrNumber = asset.FindActionMap("HeadOrNumber", throwIfNotFound: true);
        m_HeadOrNumber_Choose = m_HeadOrNumber.FindAction("Choose", throwIfNotFound: true);
        m_HeadOrNumber_MoveCourser = m_HeadOrNumber.FindAction("MoveCourser", throwIfNotFound: true);
        // JumpOrDuck
        m_JumpOrDuck = asset.FindActionMap("JumpOrDuck", throwIfNotFound: true);
        m_JumpOrDuck_Jump = m_JumpOrDuck.FindAction("Jump", throwIfNotFound: true);
        m_JumpOrDuck_Duck = m_JumpOrDuck.FindAction("Duck", throwIfNotFound: true);
        // Playfield
        m_Playfield = asset.FindActionMap("Playfield", throwIfNotFound: true);
        m_Playfield_Move = m_Playfield.FindAction("Move", throwIfNotFound: true);
        m_Playfield_Action = m_Playfield.FindAction("Action", throwIfNotFound: true);
        // MainMenu
        m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
        m_MainMenu_AddPlayer = m_MainMenu.FindAction("AddPlayer", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // BoardMovement
    private readonly InputActionMap m_BoardMovement;
    private IBoardMovementActions m_BoardMovementActionsCallbackInterface;
    private readonly InputAction m_BoardMovement_Move;
    public struct BoardMovementActions
    {
        private @InputActions m_Wrapper;
        public BoardMovementActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BoardMovement_Move;
        public InputActionMap Get() { return m_Wrapper.m_BoardMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoardMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBoardMovementActions instance)
        {
            if (m_Wrapper.m_BoardMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BoardMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BoardMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BoardMovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_BoardMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public BoardMovementActions @BoardMovement => new BoardMovementActions(this);

    // AsterioidenDoge
    private readonly InputActionMap m_AsterioidenDoge;
    private IAsterioidenDogeActions m_AsterioidenDogeActionsCallbackInterface;
    private readonly InputAction m_AsterioidenDoge_Move;
    private readonly InputAction m_AsterioidenDoge_Attack;
    public struct AsterioidenDogeActions
    {
        private @InputActions m_Wrapper;
        public AsterioidenDogeActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_AsterioidenDoge_Move;
        public InputAction @Attack => m_Wrapper.m_AsterioidenDoge_Attack;
        public InputActionMap Get() { return m_Wrapper.m_AsterioidenDoge; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AsterioidenDogeActions set) { return set.Get(); }
        public void SetCallbacks(IAsterioidenDogeActions instance)
        {
            if (m_Wrapper.m_AsterioidenDogeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_AsterioidenDogeActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_AsterioidenDogeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public AsterioidenDogeActions @AsterioidenDoge => new AsterioidenDogeActions(this);

    // HotPotato
    private readonly InputActionMap m_HotPotato;
    private IHotPotatoActions m_HotPotatoActionsCallbackInterface;
    private readonly InputAction m_HotPotato_Move;
    public struct HotPotatoActions
    {
        private @InputActions m_Wrapper;
        public HotPotatoActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HotPotato_Move;
        public InputActionMap Get() { return m_Wrapper.m_HotPotato; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HotPotatoActions set) { return set.Get(); }
        public void SetCallbacks(IHotPotatoActions instance)
        {
            if (m_Wrapper.m_HotPotatoActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_HotPotatoActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_HotPotatoActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_HotPotatoActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_HotPotatoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public HotPotatoActions @HotPotato => new HotPotatoActions(this);

    // IconLook
    private readonly InputActionMap m_IconLook;
    private IIconLookActions m_IconLookActionsCallbackInterface;
    private readonly InputAction m_IconLook_LookUp;
    private readonly InputAction m_IconLook_LookDown;
    private readonly InputAction m_IconLook_LookRight;
    private readonly InputAction m_IconLook_LookLeft;
    public struct IconLookActions
    {
        private @InputActions m_Wrapper;
        public IconLookActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LookUp => m_Wrapper.m_IconLook_LookUp;
        public InputAction @LookDown => m_Wrapper.m_IconLook_LookDown;
        public InputAction @LookRight => m_Wrapper.m_IconLook_LookRight;
        public InputAction @LookLeft => m_Wrapper.m_IconLook_LookLeft;
        public InputActionMap Get() { return m_Wrapper.m_IconLook; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IconLookActions set) { return set.Get(); }
        public void SetCallbacks(IIconLookActions instance)
        {
            if (m_Wrapper.m_IconLookActionsCallbackInterface != null)
            {
                @LookUp.started -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookUp;
                @LookUp.performed -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookUp;
                @LookUp.canceled -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookUp;
                @LookDown.started -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookDown;
                @LookDown.performed -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookDown;
                @LookDown.canceled -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookDown;
                @LookRight.started -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookRight;
                @LookRight.performed -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookRight;
                @LookRight.canceled -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookRight;
                @LookLeft.started -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookLeft;
                @LookLeft.performed -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookLeft;
                @LookLeft.canceled -= m_Wrapper.m_IconLookActionsCallbackInterface.OnLookLeft;
            }
            m_Wrapper.m_IconLookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LookUp.started += instance.OnLookUp;
                @LookUp.performed += instance.OnLookUp;
                @LookUp.canceled += instance.OnLookUp;
                @LookDown.started += instance.OnLookDown;
                @LookDown.performed += instance.OnLookDown;
                @LookDown.canceled += instance.OnLookDown;
                @LookRight.started += instance.OnLookRight;
                @LookRight.performed += instance.OnLookRight;
                @LookRight.canceled += instance.OnLookRight;
                @LookLeft.started += instance.OnLookLeft;
                @LookLeft.performed += instance.OnLookLeft;
                @LookLeft.canceled += instance.OnLookLeft;
            }
        }
    }
    public IconLookActions @IconLook => new IconLookActions(this);

    // Bomber
    private readonly InputActionMap m_Bomber;
    private IBomberActions m_BomberActionsCallbackInterface;
    private readonly InputAction m_Bomber_Move;
    private readonly InputAction m_Bomber_Jump;
    public struct BomberActions
    {
        private @InputActions m_Wrapper;
        public BomberActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Bomber_Move;
        public InputAction @Jump => m_Wrapper.m_Bomber_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Bomber; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BomberActions set) { return set.Get(); }
        public void SetCallbacks(IBomberActions instance)
        {
            if (m_Wrapper.m_BomberActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BomberActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BomberActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BomberActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_BomberActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BomberActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BomberActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BomberActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BomberActions @Bomber => new BomberActions(this);

    // TnTRun
    private readonly InputActionMap m_TnTRun;
    private ITnTRunActions m_TnTRunActionsCallbackInterface;
    private readonly InputAction m_TnTRun_Move;
    public struct TnTRunActions
    {
        private @InputActions m_Wrapper;
        public TnTRunActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_TnTRun_Move;
        public InputActionMap Get() { return m_Wrapper.m_TnTRun; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TnTRunActions set) { return set.Get(); }
        public void SetCallbacks(ITnTRunActions instance)
        {
            if (m_Wrapper.m_TnTRunActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_TnTRunActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_TnTRunActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_TnTRunActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_TnTRunActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public TnTRunActions @TnTRun => new TnTRunActions(this);

    // KnockbackPlattform
    private readonly InputActionMap m_KnockbackPlattform;
    private IKnockbackPlattformActions m_KnockbackPlattformActionsCallbackInterface;
    private readonly InputAction m_KnockbackPlattform_Move;
    private readonly InputAction m_KnockbackPlattform_KnockBack;
    public struct KnockbackPlattformActions
    {
        private @InputActions m_Wrapper;
        public KnockbackPlattformActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KnockbackPlattform_Move;
        public InputAction @KnockBack => m_Wrapper.m_KnockbackPlattform_KnockBack;
        public InputActionMap Get() { return m_Wrapper.m_KnockbackPlattform; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KnockbackPlattformActions set) { return set.Get(); }
        public void SetCallbacks(IKnockbackPlattformActions instance)
        {
            if (m_Wrapper.m_KnockbackPlattformActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnMove;
                @KnockBack.started -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnKnockBack;
                @KnockBack.performed -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnKnockBack;
                @KnockBack.canceled -= m_Wrapper.m_KnockbackPlattformActionsCallbackInterface.OnKnockBack;
            }
            m_Wrapper.m_KnockbackPlattformActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @KnockBack.started += instance.OnKnockBack;
                @KnockBack.performed += instance.OnKnockBack;
                @KnockBack.canceled += instance.OnKnockBack;
            }
        }
    }
    public KnockbackPlattformActions @KnockbackPlattform => new KnockbackPlattformActions(this);

    // DontMove
    private readonly InputActionMap m_DontMove;
    private IDontMoveActions m_DontMoveActionsCallbackInterface;
    private readonly InputAction m_DontMove_Move;
    public struct DontMoveActions
    {
        private @InputActions m_Wrapper;
        public DontMoveActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_DontMove_Move;
        public InputActionMap Get() { return m_Wrapper.m_DontMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DontMoveActions set) { return set.Get(); }
        public void SetCallbacks(IDontMoveActions instance)
        {
            if (m_Wrapper.m_DontMoveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_DontMoveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DontMoveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DontMoveActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_DontMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public DontMoveActions @DontMove => new DontMoveActions(this);

    // BiggerWins
    private readonly InputActionMap m_BiggerWins;
    private IBiggerWinsActions m_BiggerWinsActionsCallbackInterface;
    private readonly InputAction m_BiggerWins_Move;
    private readonly InputAction m_BiggerWins_Choose;
    public struct BiggerWinsActions
    {
        private @InputActions m_Wrapper;
        public BiggerWinsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BiggerWins_Move;
        public InputAction @Choose => m_Wrapper.m_BiggerWins_Choose;
        public InputActionMap Get() { return m_Wrapper.m_BiggerWins; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BiggerWinsActions set) { return set.Get(); }
        public void SetCallbacks(IBiggerWinsActions instance)
        {
            if (m_Wrapper.m_BiggerWinsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnMove;
                @Choose.started -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnChoose;
                @Choose.performed -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnChoose;
                @Choose.canceled -= m_Wrapper.m_BiggerWinsActionsCallbackInterface.OnChoose;
            }
            m_Wrapper.m_BiggerWinsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Choose.started += instance.OnChoose;
                @Choose.performed += instance.OnChoose;
                @Choose.canceled += instance.OnChoose;
            }
        }
    }
    public BiggerWinsActions @BiggerWins => new BiggerWinsActions(this);

    // BoxRunning
    private readonly InputActionMap m_BoxRunning;
    private IBoxRunningActions m_BoxRunningActionsCallbackInterface;
    private readonly InputAction m_BoxRunning_Jump;
    public struct BoxRunningActions
    {
        private @InputActions m_Wrapper;
        public BoxRunningActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_BoxRunning_Jump;
        public InputActionMap Get() { return m_Wrapper.m_BoxRunning; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoxRunningActions set) { return set.Get(); }
        public void SetCallbacks(IBoxRunningActions instance)
        {
            if (m_Wrapper.m_BoxRunningActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_BoxRunningActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BoxRunningActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BoxRunningActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BoxRunningActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BoxRunningActions @BoxRunning => new BoxRunningActions(this);

    // CatchTheToast
    private readonly InputActionMap m_CatchTheToast;
    private ICatchTheToastActions m_CatchTheToastActionsCallbackInterface;
    private readonly InputAction m_CatchTheToast_Move;
    public struct CatchTheToastActions
    {
        private @InputActions m_Wrapper;
        public CatchTheToastActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CatchTheToast_Move;
        public InputActionMap Get() { return m_Wrapper.m_CatchTheToast; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatchTheToastActions set) { return set.Get(); }
        public void SetCallbacks(ICatchTheToastActions instance)
        {
            if (m_Wrapper.m_CatchTheToastActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CatchTheToastActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CatchTheToastActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CatchTheToastActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CatchTheToastActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CatchTheToastActions @CatchTheToast => new CatchTheToastActions(this);

    // LookMindRepeat
    private readonly InputActionMap m_LookMindRepeat;
    private ILookMindRepeatActions m_LookMindRepeatActionsCallbackInterface;
    public struct LookMindRepeatActions
    {
        private @InputActions m_Wrapper;
        public LookMindRepeatActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_LookMindRepeat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookMindRepeatActions set) { return set.Get(); }
        public void SetCallbacks(ILookMindRepeatActions instance)
        {
            if (m_Wrapper.m_LookMindRepeatActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_LookMindRepeatActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public LookMindRepeatActions @LookMindRepeat => new LookMindRepeatActions(this);

    // CountTheSheep
    private readonly InputActionMap m_CountTheSheep;
    private ICountTheSheepActions m_CountTheSheepActionsCallbackInterface;
    private readonly InputAction m_CountTheSheep_CountUp;
    private readonly InputAction m_CountTheSheep_CountDown;
    public struct CountTheSheepActions
    {
        private @InputActions m_Wrapper;
        public CountTheSheepActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CountUp => m_Wrapper.m_CountTheSheep_CountUp;
        public InputAction @CountDown => m_Wrapper.m_CountTheSheep_CountDown;
        public InputActionMap Get() { return m_Wrapper.m_CountTheSheep; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CountTheSheepActions set) { return set.Get(); }
        public void SetCallbacks(ICountTheSheepActions instance)
        {
            if (m_Wrapper.m_CountTheSheepActionsCallbackInterface != null)
            {
                @CountUp.started -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountUp;
                @CountUp.performed -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountUp;
                @CountUp.canceled -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountUp;
                @CountDown.started -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountDown;
                @CountDown.performed -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountDown;
                @CountDown.canceled -= m_Wrapper.m_CountTheSheepActionsCallbackInterface.OnCountDown;
            }
            m_Wrapper.m_CountTheSheepActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CountUp.started += instance.OnCountUp;
                @CountUp.performed += instance.OnCountUp;
                @CountUp.canceled += instance.OnCountUp;
                @CountDown.started += instance.OnCountDown;
                @CountDown.performed += instance.OnCountDown;
                @CountDown.canceled += instance.OnCountDown;
            }
        }
    }
    public CountTheSheepActions @CountTheSheep => new CountTheSheepActions(this);

    // ChooseTheCloud
    private readonly InputActionMap m_ChooseTheCloud;
    private IChooseTheCloudActions m_ChooseTheCloudActionsCallbackInterface;
    private readonly InputAction m_ChooseTheCloud_JumpUp;
    private readonly InputAction m_ChooseTheCloud_JumpDown;
    private readonly InputAction m_ChooseTheCloud_JumpRight;
    private readonly InputAction m_ChooseTheCloud_JumpLeft;
    public struct ChooseTheCloudActions
    {
        private @InputActions m_Wrapper;
        public ChooseTheCloudActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @JumpUp => m_Wrapper.m_ChooseTheCloud_JumpUp;
        public InputAction @JumpDown => m_Wrapper.m_ChooseTheCloud_JumpDown;
        public InputAction @JumpRight => m_Wrapper.m_ChooseTheCloud_JumpRight;
        public InputAction @JumpLeft => m_Wrapper.m_ChooseTheCloud_JumpLeft;
        public InputActionMap Get() { return m_Wrapper.m_ChooseTheCloud; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChooseTheCloudActions set) { return set.Get(); }
        public void SetCallbacks(IChooseTheCloudActions instance)
        {
            if (m_Wrapper.m_ChooseTheCloudActionsCallbackInterface != null)
            {
                @JumpUp.started -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpUp;
                @JumpUp.performed -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpUp;
                @JumpUp.canceled -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpUp;
                @JumpDown.started -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpDown;
                @JumpDown.performed -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpDown;
                @JumpDown.canceled -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpDown;
                @JumpRight.started -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpRight;
                @JumpRight.performed -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpRight;
                @JumpRight.canceled -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpRight;
                @JumpLeft.started -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpLeft;
                @JumpLeft.performed -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpLeft;
                @JumpLeft.canceled -= m_Wrapper.m_ChooseTheCloudActionsCallbackInterface.OnJumpLeft;
            }
            m_Wrapper.m_ChooseTheCloudActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JumpUp.started += instance.OnJumpUp;
                @JumpUp.performed += instance.OnJumpUp;
                @JumpUp.canceled += instance.OnJumpUp;
                @JumpDown.started += instance.OnJumpDown;
                @JumpDown.performed += instance.OnJumpDown;
                @JumpDown.canceled += instance.OnJumpDown;
                @JumpRight.started += instance.OnJumpRight;
                @JumpRight.performed += instance.OnJumpRight;
                @JumpRight.canceled += instance.OnJumpRight;
                @JumpLeft.started += instance.OnJumpLeft;
                @JumpLeft.performed += instance.OnJumpLeft;
                @JumpLeft.canceled += instance.OnJumpLeft;
            }
        }
    }
    public ChooseTheCloudActions @ChooseTheCloud => new ChooseTheCloudActions(this);

    // Labyrinth
    private readonly InputActionMap m_Labyrinth;
    private ILabyrinthActions m_LabyrinthActionsCallbackInterface;
    private readonly InputAction m_Labyrinth_Move;
    private readonly InputAction m_Labyrinth_KnockBack;
    public struct LabyrinthActions
    {
        private @InputActions m_Wrapper;
        public LabyrinthActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Labyrinth_Move;
        public InputAction @KnockBack => m_Wrapper.m_Labyrinth_KnockBack;
        public InputActionMap Get() { return m_Wrapper.m_Labyrinth; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LabyrinthActions set) { return set.Get(); }
        public void SetCallbacks(ILabyrinthActions instance)
        {
            if (m_Wrapper.m_LabyrinthActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnMove;
                @KnockBack.started -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnKnockBack;
                @KnockBack.performed -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnKnockBack;
                @KnockBack.canceled -= m_Wrapper.m_LabyrinthActionsCallbackInterface.OnKnockBack;
            }
            m_Wrapper.m_LabyrinthActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @KnockBack.started += instance.OnKnockBack;
                @KnockBack.performed += instance.OnKnockBack;
                @KnockBack.canceled += instance.OnKnockBack;
            }
        }
    }
    public LabyrinthActions @Labyrinth => new LabyrinthActions(this);

    // ReactionSlot
    private readonly InputActionMap m_ReactionSlot;
    private IReactionSlotActions m_ReactionSlotActionsCallbackInterface;
    private readonly InputAction m_ReactionSlot_Jump;
    public struct ReactionSlotActions
    {
        private @InputActions m_Wrapper;
        public ReactionSlotActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_ReactionSlot_Jump;
        public InputActionMap Get() { return m_Wrapper.m_ReactionSlot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ReactionSlotActions set) { return set.Get(); }
        public void SetCallbacks(IReactionSlotActions instance)
        {
            if (m_Wrapper.m_ReactionSlotActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ReactionSlotActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ReactionSlotActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ReactionSlotActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ReactionSlotActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ReactionSlotActions @ReactionSlot => new ReactionSlotActions(this);

    // HeadOrNumber
    private readonly InputActionMap m_HeadOrNumber;
    private IHeadOrNumberActions m_HeadOrNumberActionsCallbackInterface;
    private readonly InputAction m_HeadOrNumber_Choose;
    private readonly InputAction m_HeadOrNumber_MoveCourser;
    public struct HeadOrNumberActions
    {
        private @InputActions m_Wrapper;
        public HeadOrNumberActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Choose => m_Wrapper.m_HeadOrNumber_Choose;
        public InputAction @MoveCourser => m_Wrapper.m_HeadOrNumber_MoveCourser;
        public InputActionMap Get() { return m_Wrapper.m_HeadOrNumber; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeadOrNumberActions set) { return set.Get(); }
        public void SetCallbacks(IHeadOrNumberActions instance)
        {
            if (m_Wrapper.m_HeadOrNumberActionsCallbackInterface != null)
            {
                @Choose.started -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnChoose;
                @Choose.performed -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnChoose;
                @Choose.canceled -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnChoose;
                @MoveCourser.started -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnMoveCourser;
                @MoveCourser.performed -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnMoveCourser;
                @MoveCourser.canceled -= m_Wrapper.m_HeadOrNumberActionsCallbackInterface.OnMoveCourser;
            }
            m_Wrapper.m_HeadOrNumberActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Choose.started += instance.OnChoose;
                @Choose.performed += instance.OnChoose;
                @Choose.canceled += instance.OnChoose;
                @MoveCourser.started += instance.OnMoveCourser;
                @MoveCourser.performed += instance.OnMoveCourser;
                @MoveCourser.canceled += instance.OnMoveCourser;
            }
        }
    }
    public HeadOrNumberActions @HeadOrNumber => new HeadOrNumberActions(this);

    // JumpOrDuck
    private readonly InputActionMap m_JumpOrDuck;
    private IJumpOrDuckActions m_JumpOrDuckActionsCallbackInterface;
    private readonly InputAction m_JumpOrDuck_Jump;
    private readonly InputAction m_JumpOrDuck_Duck;
    public struct JumpOrDuckActions
    {
        private @InputActions m_Wrapper;
        public JumpOrDuckActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_JumpOrDuck_Jump;
        public InputAction @Duck => m_Wrapper.m_JumpOrDuck_Duck;
        public InputActionMap Get() { return m_Wrapper.m_JumpOrDuck; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JumpOrDuckActions set) { return set.Get(); }
        public void SetCallbacks(IJumpOrDuckActions instance)
        {
            if (m_Wrapper.m_JumpOrDuckActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnJump;
                @Duck.started -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_JumpOrDuckActionsCallbackInterface.OnDuck;
            }
            m_Wrapper.m_JumpOrDuckActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Duck.started += instance.OnDuck;
                @Duck.performed += instance.OnDuck;
                @Duck.canceled += instance.OnDuck;
            }
        }
    }
    public JumpOrDuckActions @JumpOrDuck => new JumpOrDuckActions(this);

    // Playfield
    private readonly InputActionMap m_Playfield;
    private IPlayfieldActions m_PlayfieldActionsCallbackInterface;
    private readonly InputAction m_Playfield_Move;
    private readonly InputAction m_Playfield_Action;
    public struct PlayfieldActions
    {
        private @InputActions m_Wrapper;
        public PlayfieldActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Playfield_Move;
        public InputAction @Action => m_Wrapper.m_Playfield_Action;
        public InputActionMap Get() { return m_Wrapper.m_Playfield; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayfieldActions set) { return set.Get(); }
        public void SetCallbacks(IPlayfieldActions instance)
        {
            if (m_Wrapper.m_PlayfieldActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayfieldActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_PlayfieldActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public PlayfieldActions @Playfield => new PlayfieldActions(this);

    // MainMenu
    private readonly InputActionMap m_MainMenu;
    private IMainMenuActions m_MainMenuActionsCallbackInterface;
    private readonly InputAction m_MainMenu_AddPlayer;
    public struct MainMenuActions
    {
        private @InputActions m_Wrapper;
        public MainMenuActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @AddPlayer => m_Wrapper.m_MainMenu_AddPlayer;
        public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
            {
                @AddPlayer.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnAddPlayer;
                @AddPlayer.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnAddPlayer;
                @AddPlayer.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnAddPlayer;
            }
            m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AddPlayer.started += instance.OnAddPlayer;
                @AddPlayer.performed += instance.OnAddPlayer;
                @AddPlayer.canceled += instance.OnAddPlayer;
            }
        }
    }
    public MainMenuActions @MainMenu => new MainMenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IBoardMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IAsterioidenDogeActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IHotPotatoActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IIconLookActions
    {
        void OnLookUp(InputAction.CallbackContext context);
        void OnLookDown(InputAction.CallbackContext context);
        void OnLookRight(InputAction.CallbackContext context);
        void OnLookLeft(InputAction.CallbackContext context);
    }
    public interface IBomberActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ITnTRunActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IKnockbackPlattformActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnKnockBack(InputAction.CallbackContext context);
    }
    public interface IDontMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IBiggerWinsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnChoose(InputAction.CallbackContext context);
    }
    public interface IBoxRunningActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICatchTheToastActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface ILookMindRepeatActions
    {
    }
    public interface ICountTheSheepActions
    {
        void OnCountUp(InputAction.CallbackContext context);
        void OnCountDown(InputAction.CallbackContext context);
    }
    public interface IChooseTheCloudActions
    {
        void OnJumpUp(InputAction.CallbackContext context);
        void OnJumpDown(InputAction.CallbackContext context);
        void OnJumpRight(InputAction.CallbackContext context);
        void OnJumpLeft(InputAction.CallbackContext context);
    }
    public interface ILabyrinthActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnKnockBack(InputAction.CallbackContext context);
    }
    public interface IReactionSlotActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IHeadOrNumberActions
    {
        void OnChoose(InputAction.CallbackContext context);
        void OnMoveCourser(InputAction.CallbackContext context);
    }
    public interface IJumpOrDuckActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnDuck(InputAction.CallbackContext context);
    }
    public interface IPlayfieldActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IMainMenuActions
    {
        void OnAddPlayer(InputAction.CallbackContext context);
    }
}
