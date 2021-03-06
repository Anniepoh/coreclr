project(unixcoreconsole)

include_directories(../unixcoreruncommon)

set(CORECONSOLE_SOURCES 
    ../unixcoreruncommon/coreruncommon.cpp
    coreconsole.cpp 
)

add_executable(coreconsole
    ${CORECONSOLE_SOURCES}
)

# FreeBSD implements dlopen in libc
if(NOT CMAKE_SYSTEM_NAME STREQUAL FreeBSD)
    target_link_libraries(coreconsole 
        dl
    )
endif(NOT CMAKE_SYSTEM_NAME STREQUAL FreeBSD)

# Libc turns locks into no-ops if pthread was not loaded into process yet. Loading
# pthread by the process executable ensures that all locks are initialized properly.
target_link_libraries(coreconsole
    pthread
)

add_dependencies(coreconsole
    coreclr
)

install (TARGETS coreconsole DESTINATION .)
