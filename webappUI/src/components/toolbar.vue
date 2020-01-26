<template>
    <v-toolbar>
        <v-toolbar-title class="font-weight-bold ml-11 mr-7 pl-4" style="color:#7cfc00;">Task Turtle</v-toolbar-title>
        <v-divider
                class="ml-12 mr-2"
                vertical
        ></v-divider>
            <v-autocomplete style="width: 60vw;" hide-no-data outlined prepend-icon="mdi-magnify" placeholder="I'm searching for" class="pl-0 mt-7 mr-2" color="#7cfc00" ></v-autocomplete>
        <v-spacer></v-spacer>
        <v-badge color="#7cfc00" content="1" overlap dot>
            <v-icon>mdi-bell</v-icon>
        </v-badge>
        <v-icon class="ml-5">mdi-chat</v-icon>
        <v-divider
                class="mx-8 grey"
                inset
                vertical
        ></v-divider>
        <v-card flat>
        <v-layout row>
            <v-flex lg4>
        <v-avatar color="indigo" size="50">
            <span>36</span>
        </v-avatar>
            </v-flex>
            <v-flex lg8>
            <v-card-text class="mr-4">Jack</v-card-text>
            </v-flex>
        </v-layout>
        </v-card>


    </v-toolbar>
</template>

<script>
    //active-class="highlighted"
    //
    // :class="item.link === $route.path ? 'highlighted' : ''" :to="item.link"
    export default {
        name: "toolbar"
    }
</script>

<style scoped>

</style>