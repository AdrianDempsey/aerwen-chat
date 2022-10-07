<template>
    <div class="topBar">
        <div class="topBarBox">
            <div class="topBar_name">
                <div v-if="switchStore.isChat">
                    <span v-if="chatStore.chatUser.friendNote != null">
                        {{chatStore.chatUser.friendNote}}
                    </span>
                    <span v-else>
                        {{chatStore.chatUser.friendNickName}}
                    </span>
                </div>
                <div v-if="switchStore.isGroupChat">
                    <span v-if="chatStore.chatGroup.groupName != null">
                        {{chatStore.chatGroup.groupName}}
                    </span>
                </div>
            </div>
            <div class="topBar_tool" v-if="switchStore.isChat">
                <img src="../../assets/img/phone.png" alt="">
                <img src="../../assets/img/video.png" alt="">
            </div>
        </div>
    </div>
</template>

<script setup>
import { ref,reactive ,watch} from 'vue';
import useSwitchStore from '../../store/modules/switch'
import useChatStore from "../../store/modules/chat";

const switchStore = useSwitchStore()
const chatStore = useChatStore()


</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

.topBar {
    width: 100%;
    height: 70px;
    /* background-color: red; */
    border-bottom: rgba(121, 163, 159, 0.3) 1px solid;
    display: flex;
    align-items: center;
}

.topBarBox {
    width: 100%;
    padding: 0 20px;
    display: flex;
    justify-content: space-between;
}

.topBar_name {
    font-weight: bold;
    font-size: 1.5rem;
    color: grey;
    letter-spacing: 2px;
    font-family: 'Bebas Neue', cursive;
}
.topBar_tool img{
    width: 2rem;
    margin: 0 5px;
    cursor: pointer;
}
</style>