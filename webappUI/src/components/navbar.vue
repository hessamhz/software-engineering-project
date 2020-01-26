<template>
        <v-navigation-drawer class="mt-3" permanent>
                <v-list>
                    <v-list-item v-for="item in items" :key="item.title" link  :class="item.link === $route.path ? 'highlighted' : ''" :to="item.link">
                        <v-list-item-icon>
                       <v-icon>{{item.icon}}</v-icon>
                        </v-list-item-icon>
                        <v-list-tile-content :class="item.link === $route.path ? 'highlighted' : 'grey--text'">
                                {{ item.title }}
                        </v-list-tile-content>
                        <v-badge v-if="item.title === 'Inbox' && item.notification.length" inline :content="item.notification.length" color="#7cfc00" class="pl-9 ml-12"></v-badge>
                    </v-list-item>
                </v-list>


            <v-divider class="ml-4 mr-1"></v-divider>
                <v-list>
                    <v-list-item v-for="item in itemsdown" :key="item.title" link>
                        <v-list-item-icon>
                        <v-icon>{{item.icon}}</v-icon>
                        </v-list-item-icon>
                        <v-list-tile-content class="grey--text">{{item.title}}</v-list-tile-content>
                    </v-list-item>
                </v-list>

        </v-navigation-drawer>




</template>

<script>
    export default {
        name: "navbar",
        data () {
            return {
                items: [
                    {title: 'Home', icon: 'mdi-home', link: "/home", notification: [] },
                    {title: 'Personal', icon: 'mdi-account', link: "/personal", notification: []},
                    {title: 'Dashboard', icon: 'mdi-view-dashboard', link: "/personal", notification: []},
                    {title: 'Task', icon: 'mdi-calendar-check', link: "/task", notification: []},
                    {title: 'Payment', icon: 'mdi-view-dashboard', link: "/personal", notification: []},
                    {title: 'Inbox', icon: 'mdi-email-newsletter', link: "/personal", notification: ['aa']},
                ],
                itemsdown: [
                    {title: 'Setting', icon: 'mdi-settings', link: "/personal"},
                    {title: 'Help', icon: 'mdi-image', link: "/personal"},
                    {title: 'Issues', icon: 'mdi-view-dashboard', link: "/personal"},
                ],

            }
        }
    }
</script>

<style scoped>
    .highlighted {
        color: #7cfc00;
        background-color: aliceblue;
    }

</style>