<template>
    <ChatBackground></ChatBackground>
    <div class="box">
        <div style="display: flex; height: 100%; width: 100%;">
            <ChatLeftNav></ChatLeftNav>
            <ChatMiddleNav></ChatMiddleNav>
            <div class="chatContent">
                <PersonalCenter v-if="switchStore.isPersonal"></PersonalCenter>
                <FriendCenter v-else-if="switchStore.isFriendIntro"></FriendCenter>
                <FriendRequest v-else-if="switchStore.isFriends"></FriendRequest>
                <ChatContent v-else></ChatContent>
            </div>
        </div>
    </div>
</template>

<script setup>
import ChatBackground from '../../components/Chat/chatBackground.vue'
import ChatLeftNav from '../../components/Chat/chatLeftNav.vue'
import ChatMiddleNav from '../../components/Chat/chatMiddleNav.vue'
import ChatContent from '../../components/Chat/chatContent.vue'
import PersonalCenter from '../../components/Chat/Personal/personalCenter.vue'
import FriendCenter from '../../components/Chat/Personal/friendCenter.vue'
import FriendRequest from '../../components/Chat/Friend/FriendRequest.vue'
import useUserStore from '../../store/modules/user'
import useSwitchStore from '../../store/modules/switch'
import Cookies from 'js-cookie'
import { watch, ref, onBeforeMount } from 'vue'
import { useRoute, useRouter } from 'vue-router'
import moadl from '../../plugins/modal'

const userStore = useUserStore()
const switchStore = useSwitchStore()

let userJsonStr = sessionStorage.getItem('userInfo');
let info = JSON.parse(userJsonStr);
const router = useRouter()

watch(async (v) => {
    if (sessionStorage.getItem('userInfo') == null) {
        moadl.msgError("请登录！")
        router.push({
            path: "/login"
        })
        setTimeout(() => {
            location.reload()
        }, 500);
        return
    }
    await userStore.getUserInfo(info.chatUserName);
});
userStore.userinfo = info

</script>


<style scoped>
.box {
    width: 1100px;
    height: 700px;
    background-color: #f5f5f5;
    border-radius: 10px;
}

.chatContent {
    width: 63%;
    height: 100%;
    /* background-color: red; */
    border-left: rgba(121, 163, 159, 0.3) 1px solid;
    overflow: hidden;
}
</style>